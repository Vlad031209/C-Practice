using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());

Write("Введите второе число: ");
int number2 = int.Parse(ReadLine());

if (number / number2 == number2)
{
    WriteLine($"a = {number}, b = {number2} -> a квадрат b");
}
if (number2 / number == number)
{
    WriteLine($"a = {number}, b = {number2} -> b квадрат a");
}
if  (number2 / number != number & (number / number2 != number2))
{
        WriteLine($"a = {number}, b = {number2} -> не явлется");
}