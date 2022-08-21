using System;
using System.Globalization;

/*
 * Условный оператор SWITCH
*/


namespace Lesson12
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, а я угадаю его: ");
            int? a = int.Parse(Console.ReadLine());  // Не задываем, что мы вводим только строку в виде числа,
                                                     // которое с помощью метода int.parse преодразуется в целое число
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели число 1");
                    break;

                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;

                case 3:
                    Console.WriteLine("Вы ввели число 3");
                    break;

                case 4:
                    Console.WriteLine("Вы ввели число 4");
                    break;

                case 5:
                    Console.WriteLine("Вы ввели число 5");
                    break;

                case 6:
                    Console.WriteLine("Вы ввели число 6");
                    break;

                case 7:
                    Console.WriteLine("Вы ввели число 7");
                    break;

                case 8:
                    Console.WriteLine("Вы ввели число 8");
                    break;

                case 9:
                    Console.WriteLine("Вы ввели число 9");
                    break;

                default:
                    Console.WriteLine("Да я ХЗ, что ты там ввёл))");
                    break;
            }



            Console.Write("Теперь введите символ, а я угадаю его: ");
            string? b = Console.ReadLine();  // Не задываем, что мы вводим только строку в виде числа,
                                             // которое с помощью метода int.parse преодразуется в целое число
            switch (b)
            {
                case "-":
                    Console.WriteLine("Вы ввели символ -");
                    break;

                case "+":
                    Console.WriteLine("Вы ввели символ +");
                    break;

                case "a":
                    Console.WriteLine("Вы ввели символ a");
                    break;

                case "b":
                    Console.WriteLine("Вы ввели символ b");
                    break;

                case "c":
                    Console.WriteLine("Вы ввели символ c");
                    break;

                case "d":
                    Console.WriteLine("Вы ввели символ d");
                    break;

                case "e":
                    Console.WriteLine("Вы ввели символ e");
                    break;

                default:
                    Console.WriteLine("Да я ХЗ, что ты там ввёл))");
                    break;
            }
        }
    }
}