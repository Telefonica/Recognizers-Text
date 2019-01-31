# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
from auracog_lib.setup.utilities import parse_pkg_version
from setuptools import setup, find_packages


NAME = 'recognizers-text'
VERSION = parse_pkg_version(v_file_path=__file__)
REQUIRES = []

setup(
    name=NAME,
    version=VERSION,
    url='https://github.com/Microsoft/Recognizers-Text',
    author='Microsoft',
    description='recognizers-text README',
    keywords=['nlp', 'nlp-entity-extraction', 'entity-extraction', 'parser-library'],
    long_description='recognizers-text long README.',
    license='MIT',
    packages=find_packages(),
    install_requires=REQUIRES,
    classifiers=[
        'Programming Language :: Python :: 3.6',
        'Intended Audience :: Developers',
        'License :: OSI Approved :: MIT License',
        'Operating System :: OS Independent',
        'Development Status :: 3 - Alpha',
        'Topic :: Scientific/Engineering :: Artificial Intelligence',
    ]
)
