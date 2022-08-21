using System;

/* 
 * Программа для вычисления среднего арифметического числа 
 */

namespace Lesson5
{
    class Program5
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue;

            Console.Write("Введите первое число: ");
            firstvalue = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            secondvalue = double.Parse(Console.ReadLine());

            double result = (firstvalue + secondvalue) / 2;

            Console.WriteLine("Среднее арифметическое двух чисел: " + result);
        }
    }
}
