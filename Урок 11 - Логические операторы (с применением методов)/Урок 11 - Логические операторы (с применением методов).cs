using System;
using System.Globalization;

/*
 * Логические операторы 
*/

/*
*                   && Сокращённое И
*                   || Сокращенное ИЛИ
*                   & И
*                   ! НЕ (унарный)
*                   | ИЛИ
*/

namespace Lesson9
{
    class Program9
    {
        public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }

        static void Main(string[] args)
        {
            if (GetTemperature() | GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора");
            }
            else
            {
                Console.WriteLine("Процессор в нормальном состоянии");
            }
        }

    }
}