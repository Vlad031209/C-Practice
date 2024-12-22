using System;
using static System.Console;

Clear();

Write("Введите количество строк: ");
int num = int.Parse(ReadLine());
PrintTriangle(num); 

void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i; j++) 
        {
            Write("  ");
        }
        for (int c = 0; c <= i; c++) 
        {
            Write("   ");
            Write(factorial(i) / (factorial(c) * factorial(i - c)));
        }
        WriteLine(); 
    }
}

int factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
