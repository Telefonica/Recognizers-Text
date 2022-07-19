# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

import os
from setuptools import setup, find_packages


def read(fname):
    return open(os.path.join(os.path.dirname(__file__), fname)).read()


NAME = 'recognizers-text-suite'
VERSION = '2.0.0-nlp'
REQUIRES = ['multipledispatch==0.6.0', 'regex==2020.7.14', 'grapheme==0.6.0',
            'recognizers-text==2.2.0-nlp', 'recognizers-text-number==2.2.0-nlp',
            'recognizers-text-number-with-unit==2.0.0-nlp', 'recognizers-text-date-time==2.0.0-nlp',
            'recognizers-text-sequence==2.0.0-nlp', 'recognizers-text-choice==2.0.0-nlp']

setup(
    name=NAME,
    version=VERSION,
    url='https://github.com/Microsoft/Recognizers-Text',
    author='Microsoft',
    description='recognizers-text-suite README',
    keywords=['nlp', 'nlp-entity-extraction',
              'entity-extraction', 'parser-library'],
    long_description=read('README.rst'),
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
