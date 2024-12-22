using System;
using static System.Console;

Clear();

int nums(int n, int power)
{
    if(power == 0) return 1; 
    return n * nums(n, power - 1); 
}

Write(nums(3, 4)); 