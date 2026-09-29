using Tyuiu.PervuhinEYu.Sprint1.Task1.V6.Lib;

namespace Tyuiu.PervuhinEYu.Sprint1.Task1.V6;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #1                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #1                                                       *");
        Console.WriteLine("* Вариант #6                                                       *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Написать консольную программу, которая запрашивает у пользователя*");
        Console.WriteLine("* исходные данные, вычисляет результат по формуле (x * y) / (3 * y)*");
        Console.WriteLine("* и печатает на экран                                              *");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        Console.WriteLine("********************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadKey();
    }
}