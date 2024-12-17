using System;
using static System.Console;

Clear();

int[] GetArray(int size)
{
    int[] rl_array = new int[size]; 

    Random rnd = new Random(); 

    for(int i = 0; i < size; i++)
    {
        rl_array[i] = rnd.Next(1, 10); 
    }
    return rl_array; 
}

void GetArrayCopy(int[] array)
{
    int[] answer = new int[array.Length]; 

    Write("Оригинальный: "); 

    foreach(int e in array)
    {
        Write($"{e} "); 
    }

    WriteLine(); 

    for(int i = 0; i < array.Length; i++) 
    {
        answer[i] = array[i]; 
    }

    Write("Скопированный: "); 

    foreach(int e in answer)
    {
        Write($"{e} "); 
    }
}


int[] array = GetArray(5); 
GetArrayCopy(array); 