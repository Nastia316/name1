//Ввести два числа, перевести в двоичное представление в дополнительном коде и напечатать, сложить в столбик в двоичном
//представлении, вывести сумму, перевести в десятичное, вывести сумму в десятичном виде.
static string Binar(int a)
{
    string bin = "";
    while (a > 0)
    {
        if (a % 2 == 1) bin = bin.Insert(0, "1");
        else bin = bin.Insert(0, "0");
        a = a / 2;

    }
    return bin;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a binary = {Binar(a)}");
Console.WriteLine($"b binary = {Binar(b)}");
Console.WriteLine($"binary sum {Binar(a|b)}");
Console.WriteLine($"sum tens = {a | b}");
