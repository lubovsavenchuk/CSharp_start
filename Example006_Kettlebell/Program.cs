﻿int a = 3;
int b = 8;
int c = 2;
int d = 4;
int e = 6;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);