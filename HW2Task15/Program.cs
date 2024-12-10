using System;
using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine());

if (number == 6 || number == 7)
{
    Write("Да"); 
}
else
{
    Write("Нет"); 
}