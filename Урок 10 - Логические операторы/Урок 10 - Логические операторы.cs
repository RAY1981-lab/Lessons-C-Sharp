using System;
using System.Globalization;

/*
 * Логические операторы 
*/

/*
*                   && Сокращённое И
*                   || Сокращенное ИЛИ
*                   & И
*                   | ИЛИ
*                   ! НЕ (унарный)
*/

namespace Lesson9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант использования ! - инвертирование логического значения");
            bool isInfected = true;
            if (!isInfected)  // знак "!" - инвертирует значение (НЕ)
            {
                Console.WriteLine("Персонаж здоров");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован");
            }


            Console.WriteLine("Вариант использования && - сокращённого И");
            bool isHighTemperature = false;
            bool hasNoColling = true;
            if (isHighTemperature && hasNoColling)
            {
                Console.WriteLine("Угроза повреждения процессора");
            }
            else
            {
                Console.WriteLine("Угрозы повреждения процессора нет");
            }


            // Log1 && Log2 - истина, если оба
            // Log1 || Log2 - истина, если один из них


            Console.WriteLine("Вариант использования || - сокращённого ИЛИ");
            int fanSpeed = 3000;
            bool isHighTemperature1 = false;
            bool hasNoCooling1 = fanSpeed <= 0;
            if (isHighTemperature1 || hasNoCooling1)
            {
                Console.WriteLine("Угроза повреждения процессора");
            }
            else
            {
                Console.WriteLine("Угрозы повреждения процессора нет");
            }
        }
    }
}