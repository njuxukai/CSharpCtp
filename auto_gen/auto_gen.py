# -*- coding: utf-8 -*- 
import c_trader_parser
import c_mduser_parser

import cs_struct_parser
import cs_trader_generator
import cs_mduser_generator

src_path = '../import/ctp/include/'
c_trade_dest_path = '../cctp_trader/'
c_mduser_dest_path = '../cctp_mduser/'
csharp_desc_path = '../CSharpCtp/'

if __name__ == '__main__':
    c_trader_parser.generate_files(src_path, c_trade_dest_path)
    cs_struct_parser.generate_files(src_path, csharp_desc_path)
    cs_trader_generator.generate_files(src_path, csharp_desc_path)
    c_mduser_parser.generate_files(src_path, c_mduser_dest_path)
    cs_mduser_generator.generate_files(src_path, csharp_desc_path)