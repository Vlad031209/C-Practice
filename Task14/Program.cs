using System;
using static System.Console;

Clear();



void ConvertToBinary(int num)
{
    string code = ""; 
    while (num > 0)
    {
        if (num % 2 != 0) 
        {
            code += 1; 
            num /= 2;
        }
        else 
        {
            code += 0; 
            num /= 2; 
        }
    } 
    string rl_code = new string(code.Reverse().ToArray());

    Write(rl_code);
}

ConvertToBinary(45); 