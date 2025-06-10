using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 0;
        var stopwatch = Stopwatch.StartNew();

        // Вопрос 
        Console.WriteLine("1. в чем состоит различие между диаграммой последовательности и диаграммой кооперации?");
        Console.WriteLine("1) диаграмма последовательности используется только для отображения структуры классов, а диаграмма кооперации — только для отображения временных последовательностей.");
        Console.WriteLine("2) диаграмма последовательности делает основной акцент на упорядочении сообщений во времени, а кооперации - на структурной организации ");
        Console.WriteLine("3) диаграмма последовательности показывает только внутренние процессы одного объекта, а диаграмма кооперации — взаимодействия между разными системами.");
        Console.WriteLine("4) диаграмма последовательности предназначена для моделирования базы данных, а диаграмма кооперации — для описания пользовательских интерфейсов.");
        if (Console.ReadLine() == "2")
        {
            Console.WriteLine("Правильно!\n");
            n++;
        }
        else
        {
            Console.WriteLine("Неправильно! Правильный ответ: 2\n");
        }

        Console.WriteLine("2. какая диаграмма показывает структурную организацию объектов или ролей которые отправляют и принимают сообщения?");
        Console.WriteLine("1) диаграмма последовательности");
        Console.WriteLine("2) диаграмма коопераций");
        Console.WriteLine("3) диаграмма классов");
        Console.WriteLine("4) диаграмма состояний");
        if (Console.ReadLine() == "2")
        {
            Console.WriteLine("Правильно!\n");
            n++;
        }
        else
        {
            Console.WriteLine("Неправильно! Правильный ответ: 2\n");
        }

        Console.WriteLine("3. что такое реверс инжинеринг применительно к UML?");
        Console.WriteLine("1) создание UML - модели из существующего кода");
        Console.WriteLine("2) обратная семантическая трассировка существующего кода");
        Console.WriteLine("3) анализ и улучшение перестроенной модели");
        Console.WriteLine("4) декомпиляция выполняемых файлов");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Правильно!\n");
            n++;
        }
        else
        {
            Console.WriteLine("Неправильно! Правильный ответ: 1\n");
        }

        Console.WriteLine("4. разновидностью какой диаграммы UML являются диаграммы активностей?");
        Console.WriteLine("1) диаграмма последовательности");
        Console.WriteLine("2) диаграмма коопераций");
        Console.WriteLine("3) диаграмма классов");
        Console.WriteLine("4) диаграмма состояний");
        if (Console.ReadLine() == "4")
        {
            Console.WriteLine("Правильно!\n");
            n++;
        }
        else
        {
            Console.WriteLine("Неправильно! Правильный ответ: 4\n");
        }

        Console.WriteLine("5. сколько конечных состояний может содержать диаграмма активностей?");
        Console.WriteLine("1) нольи");
        Console.WriteLine("2) одно");
        Console.WriteLine("3) два");
        Console.WriteLine("4) больше одного");
        if (Console.ReadLine() == "4")
        {
            Console.WriteLine("Правильно!\n");
            n++;
        }
        else
        {
            Console.WriteLine("Неправильно! Правильный ответ: 4\n");
        }

        stopwatch.Stop();

        int Questions = 5; 
        double Score = (double)n / Questions * 100;

        Console.WriteLine($"Тест завершен!");
        Console.WriteLine($"Правильных ответов: {n} из {Questions}");

        if (Score >= 70)
        {
            Console.WriteLine(" Вы прошли тест"); 
        }
        else
        {
            Console.WriteLine("К сожалению, вы не прошли тест");
        }

        Console.WriteLine($"Время выполнения: {stopwatch.Elapsed.TotalSeconds:F2} секунд");

    }
}