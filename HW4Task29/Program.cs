using System;
using static System.Console;

Clear();

int[] GetArray(int a, int b, int c, int d, int e, int f, int g, int h)
{
    int[] number_array = {a, b, c, d, e, f, g, h}; 
    return number_array;
}


void PrintArray(int[] arr)
{
    WriteLine($"[{string.Join(", ", arr)}]");
}

PrintArray(GetArray(1, 2, 5, 7, 19, 7, 8, 9));
