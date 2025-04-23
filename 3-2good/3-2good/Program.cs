using System;


int a = 10;

for (int y = 0; y <= a*2; y++)
{
    for (int x = 0; x <= a*2; x++)
    {
        double distance = Math.Pow(x - a, 2) + Math.Pow(y - a, 2);

        if (distance >= Math.Pow(a - 0.5, 2) & distance <= Math.Pow(a + 0.5, 2))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
