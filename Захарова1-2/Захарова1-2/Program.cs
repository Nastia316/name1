using System;
double a, b, c, d;
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
d = Math.Pow(b, 2)-4*a*c;
Console.WriteLine(d);
if (d<0)
{
    Console.WriteLine($"корней нет");
}
else if (d==0)
{
    Console.WriteLine($"1 корень x={-b / (2*a)}");
}
else
{
    if (a==0)
    {
        Console.WriteLine($"1 корень x={-c / b}");
    }
    else
    {
        Console.WriteLine($"2 корня, х1={(-b + Math.Pow(d, 0.5)) / (2 * a)}, x2={(-b - Math.Pow(d, 0.5)) / (2 * a)}");
    }
}
