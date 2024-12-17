using System;
using static System.Console;

Clear();

Write("Введиет числа массива через пробел: "); 
string nums = ReadLine(); 

int[] GetNumsFromTheString(string numbers)
{
    string[] nums = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);  
    int[] numArray = new int[nums.Length]; 

    for(int i = 0; i < numArray.Length; i++)
    {
        numArray[i] = Convert.ToInt32(nums[i]); 
    }
    return numArray; 
}

void CountOfPosNums(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++; 
        else continue; 
    }

    string allNumbers = string.Join(", ", array); 

    Write($"{allNumbers} -> {count}"); 
}

int[] array = GetNumsFromTheString(nums); 
CountOfPosNums(array); 