using System;
using static System.Console;

Clear(); 

Write("Введите размер массива через пробел: "); 
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1])); 


int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];  
    Random rnd = new Random(); 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10); 
        }
    }
    return array; 
}

int[,] CheckTheArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if((i % 2 == 0 & j % 2 == 0) && (i != 0 & j != 0)) array[i, j] = array[i, j] * array[i, j]; 
            else continue; 
        }
    }
    return array; 
}

int[,] ShowTheDifference(int[,] array)
{
    int[,] show_array = new int[array.GetLength(0), array.GetLength(1)]; 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if((i % 2 == 0 & j % 2 == 0) && (i != 0 & j != 0))
            {
                show_array[i, j] = array[i, j]; 
            }  
            else show_array[i, j] = 0;  
        }
    }
    return show_array; 
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} "); 
        }
        WriteLine(); 
    }
}

WriteLine("Исходный массив: "); 
PrintArray(array); 
WriteLine(); 
WriteLine(); 
WriteLine("Изменённый массив: ");
PrintArray(CheckTheArray(array)); 
WriteLine(); 
WriteLine(); 
WriteLine("Массив, где разница показанна наглядно: ");
PrintArray(ShowTheDifference(array)); 
