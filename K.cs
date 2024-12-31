using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("ВВедите первое число");
        double x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        double x2 = double.Parse(Console.ReadLine());

        double sum = x1 + x2;
        Console.WriteLine($"Сумма чисел {x1} и {x2}") 
    }
}