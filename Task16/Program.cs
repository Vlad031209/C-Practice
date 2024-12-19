using System;
using static System.Console;

Clear(); 

void GetArray(int columns, int rows)
{
    int[] array = new int[columns * rows]; 
    Random rnd  = new Random(); 
    for(int i = 0; i < columns * rows; i++)
    {
        array[i] = rnd.Next(1, 10); 
    }

    int count = 0; 
    foreach(int e in array)
    {
        if(count % columns == 0)
        {
            WriteLine(); 
            Write($"{e} "); 
        }
        else
        {
            Write($"{e} ");
        }
        count++; 
    }
}