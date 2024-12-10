using System;
using static System.Console;

Clear();

double Formula(int a, int b, int c, int d)
{
    return a * b / (c + d); 
}

Write(Formula(2, 3, 1, 2)); 