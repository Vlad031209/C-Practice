using System;
using static System.Console;

Clear; 

int Fact(int N)
{
    if (N == 1 | N == 0) return 1;
    WriteLine(N); 
    return N * Fact(N - 1);
}

Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с заходом
//F5 продолжить(lj cktle.otq njxrb)