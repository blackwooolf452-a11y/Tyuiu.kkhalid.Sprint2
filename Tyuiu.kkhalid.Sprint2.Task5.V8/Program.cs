using System;
using Tyuiu.Kkhalid.Sprint2.Task5.V8.Lib;

namespace Tyuiu.Kkhalid.Sprint2.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца m (1-12):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(m, n);
            Console.WriteLine($"* Дата предыдущего дня: {result}                                         *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}