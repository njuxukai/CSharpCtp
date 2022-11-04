# -*- coding: utf-8 -*- 
from ctp_file_util import *


def is_empty_remark(line):
    return line.startswith('///')

def is_explain_remark(line):
    return line.startswith('///') and line[3] != '/'



def find_data_type_headers(lines, begin):
    headers = []
    for i in range(begin, len(lines)):
        if (i + 2 < len(lines) and is_empty_remark(lines[i]) 
            and is_explain_remark(lines[i+1]) 
            and is_empty_remark(lines[i+2])):
            headers.append(i)
    headers.append(len(lines))
    return headers

def find_struct_headers(lines, begin):
    headers = []
    for i in range(begin, len(lines)):
        if is_struct_fist_line(lines[i]):
            headers.append(i)
    headers.append(len(lines))
    return headers

def parse_data_type(src_dir):
    lines = load_src_file(src_dir + 'ThostFtdcUserApiDataType.h', skip_empty=False, skip_sharp=False)
    type_specs = []
    headers = find_data_type_headers(lines, 19)
    for i in range(len(headers) -1):
        ts =TypeSpec()
        ts.parse_from_lines(lines, headers[i], headers[i+1])
        type_specs.append(ts)
    return type_specs


def parse_struct(src_dir):
    lines = load_src_file(src_dir + 'ThostFtdcUserApiStruct.h', skip_empty=False, skip_sharp=False)
    struct_specs = []
    headers = find_struct_headers(lines, 19)
    for i in range(len(headers) -1):
        ss = StructSpec()
        ss.parse_from_lines(lines, headers[i], headers[i+1])
        struct_specs.append(ss)
    return struct_specs

def generate_files(src_dir, dest_dir):
    type_specs = parse_data_type(src_dir)
    struct_specs = parse_struct(src_dir)
    generate_data_type_file(dest_dir, type_specs)
    generate_struct_file(dest_dir, type_specs, struct_specs)


def generate_data_type_file(dest_dir, type_specs):
    template = load_template_file('./template/cs_data_type.cs.template')
    enum_template = load_template_file('./template/cs_enum.template')
    
    d = {}
    enum_lines = []
    skip_list  = ['TThostFtdcFBTEncryModeType','TThostFtdcCZCEUploadFileNameType', 
                   'TThostFtdcDCEUploadFileNameType', 'TThostFtdcSHFEUploadFileNameType',
                   'TThostFtdcCFFEXUploadFileNameType']
    skip_set =set(skip_list)
    for spec in type_specs:
        if spec.name in skip_set or len(spec.marco_specs) == 0 or len(spec.marco_specs[0].value.strip("'")) != 1:
            continue
        enum_lines.extend(generate_enum(spec, enum_template))
        enum_lines.append('')
    d['char_enums'] = add_whitespaces('\n'.join(enum_lines), 4)
    target_fpath = '{0}/CtpDataType.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)

def generate_struct_file(dest_dir, type_specs, struct_specs):
    template = load_template_file('./template/cs_struct.cs.template')
    struct_template = load_template_file('./template/cs_struct.template')
    type_spec_dict = {}
    for spec in type_specs:
        type_spec_dict[spec.name] = spec
    d = {}
    struct_lines = []
    for spec in struct_specs:
        struct_lines.extend(generate_struct(spec, type_spec_dict, struct_template))
        struct_lines.append('')
    d['struct_defines'] = add_whitespaces('\n'.join(struct_lines), 4)
    target_fpath = '{0}/CtpStruct.cs'.format(dest_dir) 
    save_cpp_file(template.format_map(d), target_fpath)

def generate_struct(struct_spec, type_spec_dict, template):
    d = {}
    d['struct_name'] = struct_spec.name
    entry_lines = []
    for e in struct_spec.entry_list:
        entry_lines.extend(generate_entry_lines(e, type_spec_dict))
    d['entry_lines'] = add_whitespaces('\n'.join(entry_lines), 4) 
    return template.format_map(d).split('\n')

def generate_entry_lines(entry_spec, type_spec_dict):
    result = []
    type_spec = type_spec_dict[entry_spec.type_name]
    if type_spec.type_kind == TYPE_KIND_CHAR:
        result.append('[MarshalAs(UnmanagedType.U1)]')
        result.append('public byte %s;' % entry_spec.entry_name)
    if type_spec.type_kind == TYPE_KIND_STRING:
        result.append('[MarshalAs(UnmanagedType.ByValTStr, SizeConst = %d)]' % type_spec.len)
        result.append('public string %s;' % entry_spec.entry_name)
    if type_spec.type_kind == TYPE_KIND_INT:
        result.append('[MarshalAs(UnmanagedType.I4)]')
        result.append('public Int32 %s;' % entry_spec.entry_name)
    if type_spec.type_kind == TYPE_KIND_DOUBLE:
        result.append( '[MarshalAs(UnmanagedType.R8)]')
        result.append('public double %s;' % entry_spec.entry_name)
    if type_spec.type_kind == TYPE_KIND_SHORT:
        result.append( '[MarshalAs(UnmanagedType.I2)]')
        result.append('public Int16 %s;' % entry_spec.entry_name)
    return result

def generate_enum(spec, template):
    d = {}
    d['enum_name'] = spec.name[1:-4] + 'Enum'
    entry_lines = []
    for macro_spec in spec.marco_specs:
        entry_lines.append('[Description("%s")]' % (macro_spec.remark.strip('/')))
        entry_lines.append('%s = (byte)%s,' % (macro_spec.postfix, macro_spec.value))
    d['entry_lines'] = add_whitespaces('\n'.join(entry_lines), 4)
    return template.format_map(d).split('\n')



