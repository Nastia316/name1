using System.Globalization;
//Заданы две строки: S и S1. Найдите количество вхождений S1 в S как подстроки.

//Replace(String, String)
//Возвращает новую строку, в которой все вхождения заданной строки в текущем экземпляре заменены другой заданной строкой.

static int Count(string S1, string S)
{
    int count = (S.Length - S.Replace(S1, "").Length) / S1.Length;
    return count;
}
Console.WriteLine("Введите строку S1, количество вхождений которой в S надо посчитать: ");
string S1 = Console.ReadLine();
Console.WriteLine("Введите строку S: ");
string S = Console.ReadLine();
Console.WriteLine(Count(S1, S));

