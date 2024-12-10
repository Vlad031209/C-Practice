using System;
using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine());

int a2 = number / 10 % 100 % 10;  
Write(a2); 