using System;

/* 
 * Инкремент и Декремент.
 * Постфиксный и префиксный.
 */

namespace Lesson7
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Производим операции с ИНКРЕМЕНТОМ и ДЕКРЕМЕНТОМ. Постфиксный вид записи");

            int a = 0;
            Console.WriteLine("Начальное значение числа a: " + a + " (Постфиксный инктемент в виде a++)");
            //  a = a + 1; Можно написать и так. Но удобнее так, как в строке ниже ))
            a++;  // Прибавляем 1 к числу a
            Console.WriteLine("Новое значение числа a: " + a);
            Console.WriteLine();

            int b = 0;
            Console.WriteLine("Начальное значение числа b: " + b + " (Постфиксный декремент в виде a--)");
            //  b = b - 1; Можно написать и так. Но удобнее так, как в строке ниже ))
            b--;  // Вычитаем 1 из числа b
            Console.WriteLine("Новое значение числа b: " + b);
            Console.WriteLine();

            Console.WriteLine("Производим операции с ИНКРЕМЕНТОМ и ДЕКРЕМЕНТОМ. Префиксный вид записи");
            int c = 1;
            Console.WriteLine("Начальное значение числа c: " + c + " (Префиксный инкремент в виде {c = ++c * c})");
            c = ++c * c;
            Console.WriteLine("Новое значение числа c: " + c);
            Console.WriteLine();

            double d = 10;
            Console.WriteLine("Начальное значение числа d: " + d + " (Префиксный декремент в виде {d = --d / d})");
            d = --d / d;
            Console.WriteLine("Новое значение числа d: " + d);
            Console.WriteLine();
        }
    }
}
