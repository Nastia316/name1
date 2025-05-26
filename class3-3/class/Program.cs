
using System;
using System.Runtime.CompilerServices;
class Compl
{
    public Compl(double Re, double im)
    {
        this.Re = Re;
        this.im = im;
    }
    public Compl(double Re)
        : this(Re, 0)
    {
    }
    public double Re;
    private double im;
    public Compl Compl_Sum (Compl a, Compl b)
    {
        Re=a.Re+b.Re;
        im=a.im+b.im;
        return new Compl(Re, im);
    }
    public Compl Compl_Sum2(Compl b)
    {
        return new Compl(this.Re+b.Re, this.im+b.im);
    }
    public void print(Compl a)
    {
        if (a.im<0)
        {
            Console.WriteLine($"{a.Re} {a.im}i");
        }
        else
        {
            Console.WriteLine($"{a.Re} + {a.im}i");
        }
    }
    public static Compl operator +(Compl a, Compl b)
    {
        return new Compl(a.Re + b.Re, a.im + b.im);
    }
    public static Compl operator *(Compl a, Compl b)
    {
        double real=a.Re*b.Re-a.im*b.im;
        double imaginary = a.Re * b.im + a.im * b.Re;
        return new Compl(real, imaginary);
    }
    public static Compl operator /(Compl a, Compl b)
    {
        double real = (a.Re * b.Re + a.im * b.im)/(Math.Pow(b.Re, 2)+ Math.Pow(b.Re, 2));
        double imaginary = (b.Re * a.im - b.im * a.Re) / (Math.Pow(b.Re, 2) + Math.Pow(b.Re, 2));
        return new Compl(real, imaginary);
    }
}

