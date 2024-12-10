using System;
using static System.Console;

Clear();

int[] array = [1, 4, 6, 8, 10]; 

Write("Введите start: ");
int start = int.Parse(ReadLine());

Write("Введите end: ");
int end = int.Parse(ReadLine());

int total = 0; 
int count = 0; 

for (int i = 0; i <= array.Length; i++)
{
    if (i == start || i == end || (i > start && i < end))
    {
        total += array[i]; 
        count += 1; 
    }
}

int answer = total / count; 

Write($"Ответ: {answer}"); 
