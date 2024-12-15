using System;
using static System.Console;

Clear();


void ShowTheArray(int[,] matrix)
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


int[,] CreateMatrix(int rawCount, int columnCount)
{
    int[,] matrix = new int[rawCount, columnCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 12);
        }
    }
    return matrix;
}


bool IsIntresting(int num)
{
    if (num < 10)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
    else
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        if (sum % 2 == 0) return true;
        else return false; 
    }
}


void IntrestingNumsOutput(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (IsIntresting(matrix[i, j])) Write($"{matrix[i, j]} "); 
            else Write("- "); 
        }
        WriteLine();
    }
}

int[,] array = CreateMatrix(4, 5);
ShowTheArray(array);
WriteLine();
WriteLine();
WriteLine();
IntrestingNumsOutput(array);