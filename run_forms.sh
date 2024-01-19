#!/bin/bash

mcs $1.cs -r:System.Windows.Forms.dll -r:System.Drawing.dll
./$1.exe
rm $1.exe
