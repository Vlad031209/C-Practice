using System;
using static System.Console;

Clear();

int Fact(int N)
{
    if (N == 1 | N == 0) return 1;
    return N * Fact(N - 1);
}

Write(Fact(5));