using System;
using static System.Console;

Clear();

string GetLettersFromString(string s)
{
    string letters = ""; 
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true) letters += e; 
    }
    return letters; 
}

string str = ReadLine(); 
string result = GetLettersFromString(str);
WriteLine(result); 