import os

from .code_writer import generate_code
from .yaml_parser import parse

HEADER_COMMENT = '''# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
# ------------------------------------------------------------------------------'''
EOL = '\n'  # Follow recommendation: Do not use os.linesep as a line terminator when
#  writing files opened in text mode (the default); use a single '\n' instead, on all platforms.
CLASS_INDENT = '    '


def generate(yaml_file_path: str, py_file_name: str, header: str, footer: str):
    with open(yaml_file_path, encoding='utf-8') as yaml_raw:
        yaml_object = parse(yaml_raw)

    code = generate_code(yaml_object)

    if not os.path.exists(os.path.dirname(py_file_name)):
        os.makedirs(os.path.dirname(py_file_name))

    with open(py_file_name, mode='w', encoding='utf-8') as file:
        file.write(HEADER_COMMENT + EOL + EOL)
        file.write(header + EOL)

        for line in code:
            file.write(CLASS_INDENT + line.write() + EOL)

        file.write(footer)
        file.write(EOL)
