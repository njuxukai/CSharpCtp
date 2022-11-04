# -*- coding: utf-8 -*- 
import re

def load_template_file(fname):
    result =  []
    with   open(fname,'r', encoding='utf-8') as f:
        result = [line for line in f.readlines()]
    return ''.join(result)

def load_src_file(fname, skip_empty=True, skip_sharp=True):
    result =  []
    with   open(fname,'r', encoding='gb2312') as f:
        result = [line.strip() for line in f.readlines()]
    if skip_empty:
        result = [line for line in result if len(line) > 0]
    if skip_sharp:
        result = [line for line in result if line[0] != '#']
    return result

               
def save_cpp_file(content, fname, encoding=None):
    if encoding is None:
        with open(fname, 'w') as f:
            f.writelines(content)
    else:
        with open(fname, 'w', encoding=encoding) as f:
            f.writelines(content)


def add_whitespaces(content, count):
    lines = content.split('\n')
    lines =[count *' ' + line for line in lines]
    return '\n'.join(lines)

def is_function_signature_line(line):
    find = line.find('(') != -1 and line.find(')') != -1
    return find

def is_remark_line(line):
    return line[0] == '/'


class ParameterSpec:
    def __init__(self):
        self.type_name = ''
        self.parameter_name = ''
        self.is_pointer = False
        self.raw_type_name = ''

    def __str__(self):
        return '%s %s' % (self.type_name, self.parameter_name)

    def parse_from_str(self, string):
        nodes = string.split(' ')
        nodes = [node for node in nodes if node != '']
        if len(nodes) <2:
            return
        name = nodes[-1]
        if name[0] == '*' or name[0] == '&':
            self.parameter_name = name[1:]
            nodes[-2] = nodes[-2] + name[0]
        else:
            self.parameter_name = name
        self.type_name = ' '.join(nodes[0:-1])
        if self.type_name.find('*') != -1:
            self.is_pointer = True
        self.raw_type_name = self.type_name.rstrip('*')
        


class FunctionSpec:
    def __init__(self):
        self.is_member = True
        self.is_static = False
        self.is_const = False
        self.name = ""
        self.rtn_type_name = ''
        self.parameter_list =[]
        self.is_virtual = False
        self.remarks = []

    def parse_from_line(self, line):
        nodes = line.split('(')
        if len(nodes) != 2:
            return False
        self.parse_header(nodes[0])
        nodes = nodes[1].split(')')
        self.parse_function_signature(nodes[0])
        if len(nodes) > 1 and nodes[1].find('const') != -1:
            self.is_const = True

    def parse_header(self, header):
        nodes = header.split(' ')
        nodes = [node for node in nodes if node.strip() != '']
        name = nodes[-1]
        if name[0] == '*' or name[0] == '&':
            self.name = name[1:]
            nodes[-2] = nodes[-2] + name[0]
        else:
            self.name = name

        name_begin_index = 0
        for i in range(len(nodes) -1):
            node = nodes[i]
            if node == 'virtual':
                self.is_virtual = True
            elif node == 'static':
                self.is_static = True
            else:
                name_begin_index = i
                break
        self.rtn_type_name = ' '.join(nodes[name_begin_index:-1])


    def parse_function_signature(self, signature):
        self.parameter_list.clear()
        nodes = signature.split(',')
        nodes = [node for node in nodes if node.strip() != '']
        for node in nodes:
            ps = ParameterSpec()
            ps.parse_from_str(node)
            self.parameter_list.append(ps)

    def to_signature(self):
        nodes = []
        if self.is_static:
            nodes.append('static')
        if self.is_virtual:
            nodes.append('virtual')
        nodes.append(self.rtn_type_name)
        candidate = self.name
        candidate += '('
        candidate += ', '.join([str(parameter) for parameter in self.parameter_list])
        candidate += ')'
        nodes.append(candidate)
        if self.is_const:
            nodes.append('const;')
        else:
            nodes.append(';')
        return ' '.join(nodes)

def is_macro_spec_line(line):
    return line.startswith('#define')

class MarcroSpec:
    def __init__(self):
        self.name = ''
        self.prefix = ''
        self.postfix = ''
        self.value = ''
        self.remark = ''

    def parse_from_line(self, line):
        nodes = line.split(' ')
        nodes = [node for node in nodes if node != '']
        self.value = nodes[-1]
        self.name = nodes[-2].strip(';')
        sections = self.name.split('_')
        self.postfix = sections[-1]
        for i in range(len(sections) -1):
            self.prefix += sections[i][0] + sections[i][1:].lower()

def is_type_spec_line(line):
    return line.startswith('typedef')

TYPE_KIND_CHAR = 11
TYPE_KIND_INT = 12
TYPE_KIND_DOUBLE = 13
TYPE_KIND_STRING = 14
TYPE_KIND_SHORT = 15

class TypeSpec:
    def __init__(self):
        self.type_kind = 0
        self.len = 0
        self.name = ''
        self.remarks = []
        self.marco_specs = []
        self.begin_line = 0
        self.end_line = 0

    def parse_from_line(self, line):
        nodes = line.split(' ')
        nodes = [node for node in nodes if node != '']
        if nodes[-2] == 'char' and nodes[-1].find('[') == -1:
            self.type_kind = TYPE_KIND_CHAR
            self.len = 1
            self.name = nodes[-1].strip(';')
            return
        if nodes[-2] == 'char' and nodes[-1].find(']') != -1:
            self.type_kind = TYPE_KIND_STRING
            i = nodes[-1].find('[')
            j = nodes[-1].find(']')
            self.len =  int(nodes[-1][i+1:j])
            self.name = nodes[-1][:i]
            return
        if nodes[-2] == 'int':
            self.type_kind = TYPE_KIND_INT
            self.len = 4
            self.name = nodes[-1].strip(';')
            return
        if nodes[-2] == 'double':
            self.type_kind = TYPE_KIND_DOUBLE
            self.len = 8
            self.name = nodes[-1].strip(';')
            return
        if nodes[-2] == 'short':
            self.type_kind = TYPE_KIND_SHORT
            self.len = 2
            self.name = nodes[-1].strip(';')
            return

    def parse_from_lines(self, lines, range_begin, range_end):
        self.remarks.extend(lines[range_begin:range_begin+3])
        self.begin_line = range_begin
        self.end_line = range_end
        for i in range(range_begin+3, range_end):
            if is_macro_spec_line(lines[i]):
                ms = MarcroSpec()
                ms.parse_from_line(lines[i])
                ms.remark = lines[i-1]
                self.marco_specs.append(ms)
            if is_type_spec_line(lines[i]):
                self.parse_from_line(lines[i])

class StructEntrySpec:
    def __init__(self):
        self.type_name = ''
        self.entry_name = ''
        self.remark = ''

    def parse_from_line(self, line):
        line = line.strip().rstrip(';').strip()
        nodes = re.split(' |\t', line)
        nodes = [node for node in nodes if node != '']
        self.entry_name = nodes[-1]
        self.type_name = nodes[-2]

def is_struct_fist_line(line):
    return line.startswith('struct')

def is_struct_end_line(line):
    return line.startswith('};')

class StructSpec:
    def __init__(self):
        self.entry_list = []
        self.remark = ''
        self.name = ''
        self.begin_line = 0
        self.end_line = 0

    def parse_from_lines(self, lines, range_begin, range_end):
        self.begin_line = range_begin
        self.end_line = range_end
        for i in range(range_begin, range_end):
            line = lines[i]
            if  is_struct_fist_line(line):
                self.name = line.split(' ')[-1]
                self.remark = lines[i -1]
                continue
            if line != '' and  line != '};' and line.endswith(';') and not is_remark_line(line):
                try:
                    ses = StructEntrySpec()
                    ses.parse_from_line(line)
                    ses.remark = lines[i-1]
                    if len(ses.type_name) == 0 or len(ses.entry_name) == 0:
                        print("Error Entry Line %d" %(i, self.name))
                    self.entry_list.append(ses)
                except:
                    print("Error Entry Line %d" %(i, self.name))
