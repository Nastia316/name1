using System;
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; i < 32; i++)
{
    // Получаем значения битов для каждого числа
    int bit1 = (a >> i) & 1;
    int bit2 = (b >> i) & 1;
    int bit3 = (c >> i) & 1;

    // Считаем количество единиц среди битов
    int countOnes = bit1 + bit2 + bit3;

    // Если количество единиц больше или равно 2, устанавливаем соответствующий бит в результате
    if (countOnes >= 2)
    {
        result |= (1 << i);
    }
}

Console.WriteLine($"Новое число: {result}");
