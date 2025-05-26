
Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[n, n];
int a = 1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Array[i, j] = a;
        a += 1;
    }
}
Console.WriteLine("массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.Write($"{Array[i, j]} ");
    }
    System.Console.WriteLine();
}
int[] Array2 = new int[n * n];
a = 0;
for (int f = 0; f < n; f++)
{
    for (int i = 0 + f; i < n; i++)
    {
        Array2[a] = Array[f+0, 0 + i];
        a += 1;
        if (i == n - 1)
        {
            for (int j = 1+f; j < n; j++)
            {
                Array2[a] = Array[j, i];
                a += 1;
                if (j == n - 1)
                {
                    for (int k = i - 1; k >= 0+f; k--)
                    {
                        Array2[a] = Array[j, k];
                        a += 1;
                        if (k == 0+f)
                        {
                            for (int m = j - 1; m > 0 + f; m--)
                            {
                                Array2[a] = Array[m, k];
                                a += 1;
                            }
                        }
                    }
                }
            }
            n -= 1;
        }
    }
}
for (int i = Array2.GetLength(0)-1; i >=0; i--)
{
    Console.WriteLine(Array2[i]);
}
