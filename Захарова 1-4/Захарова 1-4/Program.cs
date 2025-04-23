using System;
using System.Runtime.Intrinsics.X86;
int a, b, c, a2, b2, c2, a1, b1, c1;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
a2 = Convert.ToInt32(Console.ReadLine());
b2 = Convert.ToInt32(Console.ReadLine());
c2 = Convert.ToInt32(Console.ReadLine());

a1= Math.Max(a, Math.Max(b, c));
c1 = Math.Min(a, Math.Min(b, c));
b1 = a + b + c - a1 - c1;
a = Math.Max(a2, Math.Max(b2, c2));
c = Math.Min(a2, Math.Min(b2, c2));
b = a2 + b2 + c2 - a - c;

if (((double)a / a1 == (double)b / b1) & ((double)a / a1 == (double)c / c1))
{
    Console.WriteLine($"треугольники подобны");
}
else
{
    Console.WriteLine($"треугольники не подобны");
}

