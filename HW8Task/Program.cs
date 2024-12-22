using System;
using static System.Console;

Clear();

Write("Введите разеры массива через пробел: "); 
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));

Write("Введите Скаляр: "); 
int scale = int.Parse(ReadLine()); 

Write("Оригинальный массив: "); 
WriteLine(); 
PrintArray(array); 
WriteLine();
Write("Новый массив с внедрением скаляра: "); 
WriteLine(); 
PrintArray(ScalarArray(array, scale)); 


int[,] ScalarArray(int[,] array, int num)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j] * num; 
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
            array[i, j] = rnd.Next(1, 10);
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