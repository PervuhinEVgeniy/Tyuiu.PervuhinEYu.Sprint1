using Tyuiu.PervuhinEYu.Sprint1.Task0.V13.Lib;

namespace Tyuiu.PervuhinEYu.Sprint1.Task0.V13
{
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
            Console.WriteLine("* Задание #0                                                       *");
            Console.WriteLine("* Вариант #13                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать консольную программу C#, которая вычисляет выражение    *");
            Console.WriteLine("* 24/(6*2)-24/6/4                                                  *");
            Console.WriteLine("*                                                                  *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* 24/(6*2)-24/6/4                                                  *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                       *");
            Console.WriteLine("********************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}



