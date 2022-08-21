using System;
using System.Globalization;

/*конвертация строки
 * parse и tryparse
*/

namespace Lessons
{
    class Program1
    {
        static void Main(string[] args)
        {
            string str = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };


            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);
        }
    }
}