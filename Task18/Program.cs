using System;
using static System.Console;

Clear();

Write("Введите размер массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));
PrintArray(array);
WriteLine();
WriteLine($"Минимальноый элемент в позиции -> {String.Join(";", GetMinIndex(array))}");
WriteLine();
PrintArray(GetResultArray(array, GetMinIndex(array)));


int[,] GetResultArray(int[,] array, int[] index)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == index[0]) continue;  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == index[1]) continue; 
            result[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return result;
}


int[] GetMinIndex(int[,] array)
{
    int[] result = new int[] { 0, 0 };
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}