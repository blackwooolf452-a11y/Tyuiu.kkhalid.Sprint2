using System;
using Tyuiu.Kkhalid.Sprint2.Task7.V13.Lib;

namespace Tyuiu.Kkhalid.Sprint2.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);
            string output = result ? "Точка находится в заштрихованной области"
                                   : "Точка не находится в заштрихованной области";

            Console.WriteLine($"* {output,-60}*");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}