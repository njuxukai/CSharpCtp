# -*- coding: utf-8 -*- 
from c_trader_parser import parse_trader_file
from ctp_file_util import *

api_skip_list = ['CreateFtdcTraderApi', 'GetApiVersion', 'Release',
                'Init', 'Join', 'GetTradingDay', 'RegisterSpi',
                'RegisterFront', 'RegisterNameServer', 'RegisterFensUserInfo',
                'SubscribePrivateTopic', 'SubscribePublicTopic',
                'ReqAuthenticate', 'RegisterUserSystemInfo', 'SubmitUserSystemInfo',
                '~CThostFtdcTraderApi']

def generate_files(src_dir, dest_dir):
    api_specs, spi_specs = parse_trader_file(src_dir)
    generate_spi_delegate_file(spi_specs, dest_dir)
    generate_spi_event_args(spi_specs, dest_dir)
    generate_trader_dll_wrapper(api_specs, spi_specs, dest_dir)
    generate_trader_wrapper(api_specs, spi_specs, dest_dir)



def generate_spi_delegate_file(spi_specs, dest_dir):
    template  = load_template_file('./template/TraderSpiDelegates.cs.template')
    d = {}
    delegate_lines = []
    for spec in spi_specs:
        delegate_lines.extend(_generate_spi_delegate(spec))
        delegate_lines.append('')
    d['spi_delegates'] = add_whitespaces('\n'.join(delegate_lines), 4)
    target_fpath = '{0}/TraderSpiDelegates.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)


def generate_spi_event_args(spi_specs, dest_dir):
    template  = load_template_file('./template/TraderSpiEventArgs.cs.template')
    ev_fmt = load_template_file('./template/cs_event_arg.template')
    d = {}
    delegate_lines = []
    for spec in spi_specs:
        if len(spec.parameter_list) == 0:
            continue
        delegate_lines.extend(_generate_spi_event_arg(spec, ev_fmt))
        delegate_lines.append('')
    d['event_args_lines'] = add_whitespaces('\n'.join(delegate_lines), 4)
    target_fpath = '{0}/TraderSpiEventArgs.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)


def generate_trader_dll_wrapper(api_specs, spi_specs, dest_dir):
    template  = load_template_file('./template/TraderDllWrapper.cs.template')
    d = {}
    api_skip = set(api_skip_list)
    lines = []
    for spec in api_specs:
        if spec.name in api_skip:
            continue
        lines.extend(_generate_api_function_dll_wrapper(spec))
        lines.append('')
    d['api_function_lines'] = add_whitespaces('\n'.join(lines), 8)

    lines = []
    for spec in spi_specs:
        lines.extend(_generate_spi_register_dll_wrapper(spec))
        lines.append('')
    d['spi_register_lines'] = add_whitespaces('\n'.join(lines), 8)

    target_fpath = '{0}/TraderDllWrapper.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)


def generate_trader_wrapper(api_specs, spi_specs, dest_dir):
    template  = load_template_file('./template/TraderWrapper.cs.template')
    d = {}
    #delegate_vars
    lines  = []
    for spec in spi_specs:
        var_name = spec.name[0].lower() + spec.name[1:] + 'Delegate'
        lines.append('%sDelegate %s;' % (spec.name, var_name))
    d['delegate_vars'] = add_whitespaces('\n'.join(lines), 8)

    #event_declares
    lines = []
    fmt = 'public event EventHandler<%s> %s;'
    for spec in spi_specs:
        type_name = 'EventArgs'
        if len(spec.parameter_list) != 0:
            type_name = '%sEventArgs' % spec.name
        var_name = spec.name
        lines.append(fmt %(type_name, var_name))

    d['event_declares'] = add_whitespaces('\n'.join(lines), 8)
    
    #register_delegates_lines
    lines = []
    fmt = 'TraderDllWrapper.Register%sCallback(m_handler, %sDelegate);'
    for spec in spi_specs:
        node1 = spec.name
        node2 =  spec.name[0].lower() + spec.name[1:]
        lines.append(fmt % (node1, node2))
    d['register_delegates_lines'] = add_whitespaces('\n'.join(lines), 16)
    #event_fires
    lines = []
    fire_template = load_template_file('./template/cs_event_fire.template')
    for spec in spi_specs:
        lines.extend(_generate_spi_event_fire(spec, fire_template))
        lines.append('')
    d['event_fires'] = add_whitespaces('\n'.join(lines), 8)
    #init_delegates_lines
    lines = []
    for spec in spi_specs:
        lines.append('%sDelegate = Raise%s;' % (spec.name[0].lower() + spec.name[1:], spec.name))
    d['init_delegates_lines'] = add_whitespaces('\n'.join(lines),12 )
    #trader_api_functions
    lines = []
    skip_set = set(api_skip_list)
    for spec in api_specs:
        if spec.name in skip_set:
            continue
        lines.extend(_generate_api_caller(spec))
        lines.append('')
    d['trader_api_functions'] = add_whitespaces('\n'.join(lines) ,8)
    target_fpath = '{0}/TraderWrapper.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)

def _generate_api_caller(spec):
    d = {}
    template = '''public {spec_rtn_type_name} {spec_name}({parameter_list})
{{
        return TraderDllWrapper.{spec_name}({argument_list});
}}'''
    d['spec_rtn_type_name'] = spec.rtn_type_name
    d['spec_name'] = spec.name
    d['parameter_list'] = ', '.join(['%s %s'%(par.raw_type_name, par.parameter_name) for par in spec.parameter_list])
    arguments = ['m_handler']
    for par in spec.parameter_list:
        if par.is_pointer:
            arguments.append('ref %s' % par.parameter_name)
        else:
            arguments.append(par.parameter_name)
    d['argument_list'] = ', '.join(arguments)
    return template.format_map(d).split('\n')

def _generate_spi_event_fire(spec, fire_template):
    d = {}
    #spi_name
    d['spi_name'] = spec.name
    d['spi_name2'] = spec.name
    if len(spec.parameter_list) == 0:
        d['spi_name2'] = ''
    #parameter_list
    nodes = []
    for i in range(len(spec.parameter_list)):
        par = spec.parameter_list[i]
        if par.is_pointer:
            nodes.append('IntPtr ptr%d' % i)
        else:
            nodes.append('%s %s' % (par.raw_type_name, par.parameter_name))
    d['parameter_list'] = ', '.join(nodes)
    #argument_list
    d['argument_list'] = ', '.join([par.parameter_name for par in spec.parameter_list])
    #event_name
    d['event_name'] =   spec.name
    #intptr_argument_convert_lines
    lines = []
    for i in range(len(spec.parameter_list)):
        par = spec.parameter_list[i]
        if par.is_pointer:
            lines.append('%s? %s = null;' % (par.raw_type_name, par.parameter_name));
            lines.append('if (ptr%d != IntPtr.Zero)' % i)
            lines.append('    %s = Marshal.PtrToStructure<%s>(ptr%d);' % (par.parameter_name, par.raw_type_name, i))
    d['intptr_argument_convert_lines'] = add_whitespaces('\n'.join(lines), 4)
    return fire_template.format_map(d).split('\n')

def _generate_spi_delegate(spec):
    lines = []
    lines.append('[UnmanagedFunctionPointer(CallingConvention.Cdecl)]')
    declare_fmt = 'public delegate void %sDelegate (%s);'
    argument_list = ''
    if len(spec.parameter_list) > 0:
        nodes = []
        for parameter in spec.parameter_list:
            tn = ''
            tv = ''
            if parameter.is_pointer:
                tn = 'IntPtr'
            elif parameter.type_name == 'bool':
                tn = '[MarshalAs(UnmanagedType.U1)]bool'
            else:
                tn = parameter.type_name
            tv = parameter.parameter_name
            nodes.append('%s %s' %(tn, tv))
        argument_list = ', '.join(nodes)
    lines.append(declare_fmt %(spec.name, argument_list))
    return lines

def _generate_spi_event_arg(spec, tmplate):
    d = {}
    #spi_name
    d['spi_name'] = spec.name
    #argument_list
    nodes = []
    for parameter in spec.parameter_list:
        nk = parameter.raw_type_name
        if parameter.is_pointer:
            nk += '?'
        nodes.append('%s %s' %(nk, parameter.parameter_name))
    d['argument_list'] = ', '.join(nodes)
    #member_assign_lines
    lines = []
    for parameter in spec.parameter_list:
        lines.append('m_%s = %s;' %(parameter.parameter_name, parameter.parameter_name))
    d['member_assign_lines'] = add_whitespaces('\n'.join(lines), 8)
    #property_lines
    lines = []
    fmt = 'public %s %s {get {return m_%s; }}'
    for parameter in spec.parameter_list:
        nk = parameter.raw_type_name
        if parameter.is_pointer:
            nk += '?'
        nv = parameter.parameter_name[0].upper() + parameter.parameter_name[1:]

        lines.append(fmt %(nk, nv, parameter.parameter_name))
    d['property_lines'] = add_whitespaces('\n'.join(lines), 4)
    #member_lines
    lines = []
    fmt = 'public readonly %s m_%s ;'
    for parameter in spec.parameter_list:
        nk = parameter.raw_type_name
        if parameter.is_pointer:
            nk += '?'
        lines.append(fmt %(nk, parameter.parameter_name))
    d['member_lines'] = add_whitespaces('\n'.join(lines), 4)

    return tmplate.format_map(d).split('\n')
    


def _generate_api_function_dll_wrapper(spec):
    lines = []
    line1_fmt = '[DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "%s",'
    lines.append(line1_fmt % spec.name)
    lines.append('    CallingConvention = CallingConvention.Cdecl)]')
    line3_fmt = 'public static extern %s %s(%s);'
    nodes = []
    nodes.append('IntPtr phandler')
    for par in spec.parameter_list:
        nv = par.raw_type_name
        if par.is_pointer:
            nv = 'ref ' + nv
        nodes.append('%s %s' % (nv, par.parameter_name))
    lines.append(line3_fmt % (spec.rtn_type_name, spec.name, ', '.join(nodes)))
    return lines


def _generate_spi_register_dll_wrapper(spec):
    '''
    [DllImport("xcptraderapi.dll", CharSet = CharSet.Auto, EntryPoint = "registerFP_OnRspQrySecurityAccount",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int RegisterOnRspQrySecurityAccountCallback(IntPtr phandler,
            OnRspQrySecurityAccountDelegate callback);
            '''
    line1_fmt = '[DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFP%s",'
    line2 = '    CallingConvention = CallingConvention.Cdecl)]'
    line3_fmt = 'public static extern void Register%sCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]%sDelegate callback);'
    lines = []
    lines.append(line1_fmt % spec.name)
    lines.append(line2)
    lines.append(line3_fmt % (spec.name, spec.name))
    return lines
    

