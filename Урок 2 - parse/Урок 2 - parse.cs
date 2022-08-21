using System;
using System.Globalization;

/*конвертация строки
 * parse и tryparse
*/

namespace Lessons2
{
    class Program2
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            string str1 = "5";
            int a = int.Parse(str1, numberFormatInfo);

            string str2 = "3.14";
            double b = double.Parse(str2, numberFormatInfo);


            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}