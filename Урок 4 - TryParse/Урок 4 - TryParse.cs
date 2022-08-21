using System;
using System.Globalization;

/*Преобразование типов данных. 
 * Метод TryParse
 */

namespace Lesson4
{
    class Program4
    {
        static void Main(string[] args)
        {
            string str = "1";
            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Конвертация успешна! Значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
        }
    }
}





