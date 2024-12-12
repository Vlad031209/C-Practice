using System;
using static System.Console;

Clear();


int[] RandomElements(int size)
{
    int[] result = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2); 
    } 
    return result; 
}

WriteLine(String.Join(",", RandomElements(8)));