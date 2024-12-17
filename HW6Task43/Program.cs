using System;
using static System.Console;

Clear();

Write("Введите b1: "); 
double b1 = double.Parse(ReadLine()); 

Write("Введите k1: "); 
double k1 = double.Parse(ReadLine()); 

Write("Введите b2: "); 
double b2 = double.Parse(ReadLine()); 

Write("Введите k2: "); 
double k2 = double.Parse(ReadLine()); 

void ReturnIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k1 * x + b1;

    Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})"); 
}

ReturnIntersection(b1, k1, b2, k2); 