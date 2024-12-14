using System;
using static System.Console;

Clear();

Write("Введите числа: ");
int[] array = GetArrayFromString(ReadLine());

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}


WriteLine($"[{string.Join(", ", array)}]");
