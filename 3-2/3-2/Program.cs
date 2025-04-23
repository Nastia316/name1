//Напечатать в терминальном окне окружность из символов «*» (при помощи циклов).
int a = 5;
for (int i = a; i!=0; i--)
{
    string o = "";
    for (int j = 0; j!=i; j++)
    {
        o = o + "  ";
    }
    o += "*";
    for (int k = 0; k != a - i; k++)
    {
        o = o + "    ";
    }
     o += "*";
    Console.WriteLine(o);
}
for (int i1 = 0; i1 != a+1; i1++)
{
    string o = "";
    for (int j1 = 0; j1 != i1; j1++)
    {
        o = o + "  ";
    }
    o = o + "*";
    for (int k1 = 0; k1 != a - i1; k1++)
    {
        o = o + "    ";
    }
    o += "*";
    Console.WriteLine(o);
}
