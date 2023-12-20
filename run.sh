#!/bin/bash

mcs $1.cs
./$1.exe
rm $1.exe
