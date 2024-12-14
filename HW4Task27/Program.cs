﻿using System;
using static System.Console;

Clear();

int SumOfDigits(int a)
{
    int total = 0; 

    while (a > 0)
    {
        total += a % 10; 
        a /= 10; 
    }
    return total; 
}

Write(SumOfDigits(9012)); 