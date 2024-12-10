using System;
using static System.Console; 

Write("Введите число: ");
int number = int.Parse(ReadLine());

if (number < 100)
{
    Write("Третьей цифры нет. "); 
}
else
{
    while (number > 999)
    {
        number /= 10; 
    }
    Write(number % 10); 
}