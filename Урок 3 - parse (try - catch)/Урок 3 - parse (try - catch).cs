using System;
using System.Globalization;

/*конвертация строки
 * parse и tryparse
*/

namespace Lessons3
{
    class Program3
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };


            string str1 = "5";
            try
            {
                int a = int.Parse(str1, numberFormatInfo);
                Console.WriteLine("Успешная конвертация в INT");
                Console.WriteLine(a);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации в INT");
            }


            string str2 = "3.14";
            try
            {
                double b = double.Parse(str2, numberFormatInfo);
                Console.WriteLine("Успешная конвертация в DOUBLE");
                double c = b * 2;
                Console.WriteLine(b + "      " + c);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации в DOUBLE");
            }
        }
    }
}