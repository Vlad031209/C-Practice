using System;
using static System.Console;

Clear(); 

Write("Введите размер массива через пробел: ");
string? input = ReadLine();  // Allow null value for the input string
if (string.IsNullOrEmpty(input))
{
    WriteLine("Ввод не может быть пустым!");
    return;  // Exit the program early or you can prompt the user again
}

string[] nums = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));
PrintArray(array);

int[] rowA = GetRowArray(array);
SortArray(rowA);
WriteLine(rowA);
WriteLine();
PrintData(rowA); 

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

int[] GetRowArray(int[,] inArray)
{
    int[] rowArray = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowArray[index] = inArray[i, j];
            index++;
        }
    }
    return rowArray;
}

void SortArray(int[] rowArray)
{
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = i + 1; j < rowArray.Length; j++)
        {
            if (rowArray[i] > rowArray[j])
            {
                int k = rowArray[i];
                rowArray[i] = rowArray[j];
                rowArray[j] = k;
            }
            else continue;
        }
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            WriteLine($"{el} встречается {count} раз");
            el = inArray[i];
            count = 1;
        }
        else count++;
    }
    WriteLine($"{el} встречается {count} раз");
}
