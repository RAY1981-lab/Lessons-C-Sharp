using System;

/* 
 * Операторы отношений
 * Операции сравнения
 */


/*
 *                               == Равно
 *                               != Не равно
 *                                > Больше
 *                                < Меньше
 *                               >= Больше или равно
 *                               <= Меньше или равно
 */

namespace Lesson8
{
    class Program8
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} = b={b}: " + (a == b));

            bool result1 = a == b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} = b={b}: " + result1);

            bool result2 = a != b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} != b={b}: " + result2);

            bool result3 = a < b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} < b={b}: " + result3);

            bool result4 = a > b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} > b={b}: " + result4);

            bool result5 = a >= b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} >= b={b}: " + result5);

            bool result6 = a <= b;
            Console.WriteLine($"Итог по результату сравнения 2-х переменных a={a} <= b={b}: " + result6);
        }
    }
}
