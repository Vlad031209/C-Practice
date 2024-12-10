int n = 10;

int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };

int i = 0;

int max = array[i]; 

while (i < n)
{
    if (max < array[i])
    {
        max = array[i]; 
    }
    i++;
}
Console.WriteLine(max); 


max = array[0]; 
for (int j = 0; j < n; j++)
{
    if (max < array[j])
    {
        max = array[j]; 
    }
}

Console.WriteLine(max); 


max = array[0]; 
foreach (int e in array)
{
    if (max < e)
    {
        max = e; 
    }
}

Console.WriteLine(max); 