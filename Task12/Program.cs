using System;
using static System.Console;

Clear();

int[,] matrix = new int [3, 5];

Random rnd = new Random(); 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11); 
    }
}



int[,] CreateMatrix(int rawCount, int columnCount)
{
    int[,] matrix = new int [rawCount, columnCount];

    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11); 
        }
    }
    return matrix; 
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} "); 
        }
        WriteLine(); 
    }
}

int[,] array = CreateMatrix(4, 5); 
ShowMatrix(array); 