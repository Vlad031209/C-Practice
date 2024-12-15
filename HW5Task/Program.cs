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

int[] DeletingNegNums(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    int[] answer = new int[count];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            answer[j] = array[i];
            j++;
        }
    }

    return answer;
}

Write($"[{string.Join(", ", DeletingNegNums(array))}]"); 
