//Ввести вещественное число -1 <= x <= 1 и вычислить приближение к e^x, пользуясь формулой
//Закончить вычисления, когда очередное слагаемое станет меньше 10^-6

static double Factorial(double n)
{
    double factorial = 1;
    for (double i = 1; i <= n; i++)
        factorial *= i;

    return factorial;
}

Console.WriteLine("enter x (-1<=x<=1)");
double x = Convert.ToDouble(Console.ReadLine());
double e = 1;
for (double i = 1; ; i++)
{
    e += Math.Pow(x, i) / Factorial(i);
    if (Math.Pow(x, i) / Factorial(i) < 0.000001)
    {
        break;
    }
}
Console.WriteLine($"e^x= {e}");
