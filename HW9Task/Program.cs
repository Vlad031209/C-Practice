using System;
using static System.Console;

Clear();

Write("Введите m: "); 
int m  = int.Parse(ReadLine()); 

Write("Введите n: "); 
int n  = int.Parse(ReadLine()); 

int Sum(int start, int stop)
{
    if(stop == start) return start; 
    return start + Sum(start + 1, stop); 
}

Write(Sum(m, n)); 