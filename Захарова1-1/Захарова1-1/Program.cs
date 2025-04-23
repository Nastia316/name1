using System;
int n, i, j;
n = Convert.ToInt32(Console.ReadLine());
for (i = 2; i < n; i++)
{
    j = 2;
    for (; j <= Math.Sqrt(i); j++)
    {
        if (i%j == 0)
        {
            break;
        }
    }
    if (j > Math.Sqrt(i)) Console.WriteLine(i);
}