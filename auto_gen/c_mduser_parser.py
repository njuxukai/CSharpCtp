# -*- coding: utf-8 -*- 
from ctp_file_util import *



mduser_api_export_skip_list = ['Init','Release','Join', 'RegisterSpi', 'SubscribePrivateTopic', 'SubscribePublicTopic', 'ReqUserLogin', 'ReqAuthenticate',
                               'SubscribeMarketData', 'UnSubscribeMarketData','SubscribeForQuoteRsp','UnSubscribeForQuoteRsp']
mduser_spi_define_auto_gen_skip_list = ['OnFrontConnected', 'OnRspAuthenticate', 'OnRspUserLogin']

def parse_mduser_file(src_path):
    lines = load_src_file(src_path + 'ThostFtdcMdApi.h')
    api_function_specs = []
    spi_function_specs = []
    in_api_body = False
    in_spi_body = False
    for i in range(len(lines)):
        line = lines[i]
        if is_remark_line(line):
            continue
        if line.find('class') != -1 and line.find('CThostFtdcMdApi') != -1:
            in_api_body = True
            continue
        if line.find('class') != -1 and line.find('CThostFtdcMdSpi') != -1:
            in_spi_body = True
            continue
        if line[0:2] == '};':
            in_api_body = False
            in_spi_body = False
            continue
        if is_function_signature_line(line):
            func_spec = FunctionSpec()
            func_spec.parse_from_line(line)
            j = i - 1
            while is_remark_line(lines[j]):
                j = j -1
            func_spec.remarks.extend(lines[j+1:i])
            if in_api_body:
                api_function_specs.append(func_spec)
            if in_spi_body:
                spi_function_specs.append(func_spec)
    for spec in api_function_specs:
        spec.is_virtual = False
    return api_function_specs, spi_function_specs

def generate_c_header(dest_path, api_func_specs, spi_func_specs):
    template  = load_template_file('./template/cctp_mduser.h.template')
    d = {}

    fp_define_lines = []
    line_template = 'typedef void(__cdecl *%s)(%s) ;'
    fp_name_template = 'FuncPtrMd%s'
    for spec in spi_func_specs:
        fp_name = fp_name_template % spec.name
        parameters = ', '.join([str(parameter) for parameter in spec.parameter_list])
        fp_define_lines.append(line_template %(fp_name, parameters))
    d['md_fp_types'] = add_whitespaces('\n'.join(fp_define_lines), 0)

    #trader_api_declare
    lines = []
    line_template = 'API_EXPORT %s %s(void* mduser);'
    line_template2 = 'API_EXPORT %s %s(void* mduser, %s);'
    skip_api_names = set(mduser_api_export_skip_list)
    for spec in api_func_specs:
        if (spec.is_static 
            or spec.name in skip_api_names 
            or spec.rtn_type_name == ''
            or spec.name.find('Register') != -1):
            continue
        if len(spec.parameter_list) == 0:
            lines.append(line_template %(spec.rtn_type_name, spec.name))
        else:
            argument_list_string = ', '.join([str(parameter) for parameter in spec.parameter_list])
            lines.append(line_template2 %(spec.rtn_type_name, spec.name, argument_list_string))
    d['md_api_declare'] = add_whitespaces('\n'.join(lines), 4)
        
    #trader_spi_register
    lines = []
    line_template = 'API_EXPORT void RegisterMdFP%s(void* mduser, FuncPtrMd%s fp);'
    for spec in spi_func_specs:
        if spec.name in skip_api_names or spec.rtn_type_name == '':
            continue
        lines.append(line_template %(spec.name, spec.name))
    d['md_spi_register'] = add_whitespaces('\n'.join(lines), 4)

    target_fpath = '{0}/cctp_mduser.h'.format(dest_path) 
    save_cpp_file(template.format_map(d), target_fpath)


def generate_c_source(dest_path, api_func_specs, spi_func_specs):
    template  = load_template_file('./template/cctp_mduser.cpp.template')
    d = {}

    func_tmplate  = load_template_file('./template/function.template')
    #api_call_functions
    lines = []
    skip_api_names = set(mduser_api_export_skip_list)
    for spec in api_func_specs:
        if (spec.is_static 
            or spec.name in skip_api_names 
            or spec.rtn_type_name == ''
            or spec.name.find('Register') != -1):
            continue
        lines.append(_generate_c_api_call_function(spec, func_tmplate))
        lines.append('') 
    d['api_call_functions'] = add_whitespaces('\n'.join(lines), 0)

    #register_spi_functions
    lines = []
    for spec in spi_func_specs:
        lines.append(_generate_c_spi_register_function(spec, func_tmplate))
        lines.append('') 
    d['register_spi_functions'] = add_whitespaces('\n'.join(lines), 0)

    target_fpath = '{0}/cctp_mduser.cpp'.format(dest_path)
    save_cpp_file(template.format_map(d), target_fpath)

def _generate_c_api_call_function(spec, template):
    d = {}
    d['rtn_type_name'] = spec.rtn_type_name
    d['func_name'] =   spec.name
    parameters = ', '.join([str(parameter) for parameter in spec.parameter_list])
    arguments = ', '.join([parameter.parameter_name for parameter in spec.parameter_list])
    if len(parameters) == 0:
        parameters = 'void* phandler'
    else:
        parameters = 'void* phandler, ' + parameters
    d['parameter_list'] = parameters
    body_template ='''    CMdUser* pMdUser = (CMdUser*)phandler;
    return pMdUser->%s(%s);'''


    d['function_body'] =  add_whitespaces(body_template %(spec.name, arguments), 0)
    return template.format_map(d)

def _generate_c_spi_register_function(spec, template):
    d = {}
    d['rtn_type_name'] = 'void'
    d['func_name'] =   'RegisterMdFP%s' % spec.name
    parameters = 'void* phandler, FuncPtrMd%s fp' % spec.name
    d['parameter_list'] = parameters
    body_template ='''    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_%s(fp);'''


    d['function_body'] =  add_whitespaces(body_template %(spec.name), 0)
    return template.format_map(d)


def generate_mduser_header(dest_path, api_func_specs, spi_func_specs):
    template  = load_template_file('./template/CMdUser.h.template')
    d = {}
    #api_function_signatures
    skip_func_names = set(mduser_api_export_skip_list)
    lines = [spec.to_signature() for spec in api_func_specs if spec.name not in skip_func_names and 
             not spec.is_static and spec.name[0] != '~' and spec.rtn_type_name != '']
    d['api_function_signatures'] = add_whitespaces('\n'.join(lines), 4)


    #spi_function_signatures
    lines = [spec.to_signature() for spec in spi_func_specs]
    d['spi_function_signatures'] = add_whitespaces('\n'.join(lines), 4)

    #register_fp_functions
    lines = []
    line_template = 'void registerFP_%s(FuncPtrMd%s fp);'
    for spec in spi_func_specs:
        lines.append(line_template %(spec.name, spec.name))
    d['register_fp_functions'] = add_whitespaces('\n'.join(lines), 4)


    #registered_flags
    lines = []
    line_template = 'bool m_%sRegistered;'
    for spec in spi_func_specs:
        func_name = spec.name
        func_name = func_name[0].lower() + func_name[1:]
        lines.append(line_template % func_name)
    d['registered_flags'] = add_whitespaces('\n'.join(lines), 4)

    #function_pointers
    lines = []
    line_template = '%s %s;'
    for spec in spi_func_specs:
        fp_type_name = 'FuncPtrMd%s' % spec.name
        fp_name = 'm_fp%s' % spec.name
        lines.append(line_template % (fp_type_name, fp_name))
    d['function_pointers'] = add_whitespaces('\n'.join(lines), 4)


    target_fpath = '{0}/CMdUser.h'.format(dest_path) 
    save_cpp_file(template.format_map(d), target_fpath)

def generate_mduser_source(dest_path, api_func_specs, spi_func_specs):
    template  = load_template_file('./template/CMdUser.cpp.template')
    d = {}

    #set_bools
    lines =  _generate_cpp_set_bools(spi_func_specs)
    d['set_bools'] = add_whitespaces('\n'.join(lines), 4)

    #call_api_functions
    lines =  _generate_cpp_call_api_functions(api_func_specs)
    d['call_api_functions'] = add_whitespaces('\n'.join(lines), 0)

    #link_spi_to_callback
    lines =  _generate_cpp_link_spi_to_callbacks(spi_func_specs)
    d['link_spi_to_callback'] = add_whitespaces('\n'.join(lines), 0)

    #register_callback
    lines =  _generate_cpp_register_callbacks(spi_func_specs)
    d['register_callback'] = add_whitespaces('\n'.join(lines), 0)

    target_fpath = '{0}/CMdUser.cpp'.format(dest_path) 
    save_cpp_file(template.format_map(d), target_fpath)

def _generate_cpp_set_bools(spi_func_specs):
    lines = []
    for spec in spi_func_specs:
        func_name = spec.name
        func_name = func_name[0].lower() + func_name[1:]
        lines.append( 'm_%sRegistered = false;' % func_name)
    return lines

def  _generate_cpp_call_api_functions(api_func_specs):
    lines = []
    skip_func_names = set(mduser_api_export_skip_list)
    template  = load_template_file('./template/function.template')
    for spec in api_func_specs:
        if spec.is_static or spec.name in skip_func_names or spec.rtn_type_name == '':
            continue
        lines.append(_generate_cpp_call_api_function(spec, template))
        lines.append('\n')
    return lines

def _generate_cpp_call_api_function(spec, template):
    d = {}
    d['rtn_type_name'] = spec.rtn_type_name
    d['func_name'] = 'CMdUser::%s' % spec.name
    d['parameter_list'] = ', '.join([str(parameter) for parameter in spec.parameter_list])
    arguments = ', '.join([parameter.parameter_name for parameter in spec.parameter_list])
    body_template ='''if(m_pApi)
{
    m_pApi->%s(%s);
}'''

    body_template2 ='''if(m_pApi)
{
    return m_pApi->%s(%s);
}
else
{
    return %s;
}'''
    rtn_tag = ''
    if spec.rtn_type_name == 'void' or spec.rtn_type_name == '':
        
        d['function_body'] =  add_whitespaces(body_template %(spec.name, arguments), 4)
    elif spec.rtn_type_name == 'int':
        d['function_body'] =  add_whitespaces(body_template2 %(spec.name, arguments, 'API_NULLPTR'), 4)
    elif spec.rtn_type_name.find('char*') != -1:
        d['function_body'] =  add_whitespaces(body_template2 %(spec.name, arguments, '""'), 4)
    return template.format_map(d)

def _generate_cpp_link_spi_to_callbacks(spi_func_specs):
    lines = []
    skip_func_names = []
    skip_func_names = set(mduser_spi_define_auto_gen_skip_list)
    template  = load_template_file('./template/function.template')
    for spec in spi_func_specs:
        if not spec.is_virtual or spec.name in skip_func_names:
            continue
        lines.append(_generate_cpp_link_spi_to_callback(spec, template))
        lines.append('\n')
    return lines

def _generate_cpp_link_spi_to_callback(spec, template):
    d = {}
    d['rtn_type_name'] = spec.rtn_type_name
    d['func_name'] = 'CMdUser::%s' % spec.name
    d['parameter_list'] = ', '.join([str(parameter) for parameter in spec.parameter_list])
    arguments = ', '.join([parameter.parameter_name for parameter in spec.parameter_list])
    body = """if (m_%sRegistered)
{
    m_fp%s(%s);
}"""
    'bool m_%sRegistered;'
    lower_name = spec.name[0].lower() + spec.name[1:]
    arguments = ', '.join([parameter.parameter_name for parameter in spec.parameter_list])
    d['function_body'] = add_whitespaces(body %(lower_name, spec.name, arguments), 4)
    return template.format_map(d)

def _generate_cpp_register_callbacks(spi_func_specs):
    lines = []
    skip_func_names = []
    skip_func_names = set(skip_func_names)
    template  = load_template_file('./template/function.template')
    for spec in spi_func_specs:
        if not spec.is_virtual:
            continue
        lines.append(_generate_cpp_register_callback(spec, template))
        lines.append('\n')
    return lines

def _generate_cpp_register_callback(spec, template):
    d = {}
    d['rtn_type_name'] = 'void'
    d['func_name'] = 'CMdUser::registerFP_%s' % spec.name
    d['parameter_list'] = 'FuncPtrMd%s fp' % spec.name
    body = '''m_fp%s = fp;
m_%sRegistered = true;'''
    lower_name = spec.name[0].lower() + spec.name[1:]
    d['function_body'] = add_whitespaces(body %(spec.name,lower_name), 4)
    return template.format_map(d)

def generate_files(src_path, c_dest_path):
    api_function_specs, spi_function_specs = parse_mduser_file(src_path)
    generate_c_header(c_dest_path, api_function_specs, spi_function_specs)
    generate_c_source(c_dest_path, api_function_specs, spi_function_specs)
    generate_mduser_header(c_dest_path, api_function_specs, spi_function_specs)
    generate_mduser_source(c_dest_path, api_function_specs, spi_function_specs)

