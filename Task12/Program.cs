using System;
using static System.Console;

Clear();

int[,] matrix = new int [1, 5];

Random rnd = new Random(); 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11); 
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        WriteLine($"{matrix[i, j]} "); 
    }
}