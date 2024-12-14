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

int[] MultiplicationOfElements(int[] array)
{
    int[] answer_array = new int[(array.Length + 1) / 2]; 
    int last_index = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++)
    {
        answer_array[i] = array[i] * array[last_index];
        last_index -= 1;
    }

    // If the array length is odd, the middle element remains unchanged
    if (array.Length % 2 != 0)
    {
        answer_array[answer_array.Length - 1] = array[array.Length / 2];
    }

    return answer_array;
}

Write($"[{string.Join(", ", array)}] -> [{string.Join(", ", MultiplicationOfElements(array))}]");
