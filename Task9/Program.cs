using System;
using static System.Console;

Clear(); 

Write("Введите X: "); 
int x = int.Parse(ReadLine()); 

Write("Введите Y: "); 
int y = int.Parse(ReadLine()); 

if (x > 0 & y > 0)
{
    WriteLine($"{x};{y} -> 1"); 
}
if (x < 0 & y > 0)
{
    WriteLine($"{x};{y} -> 2"); 
}
if (x < 0 & y < 0)
{
    WriteLine($"{x};{y} -> 3"); 
}
if (x > 0 & y < 0)
{
    WriteLine($"{x};{y} -> 4"); 
}