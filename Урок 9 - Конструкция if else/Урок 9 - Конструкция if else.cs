using System;
using System.Globalization;

/*Конструкция if else 
*/

/*
*                   if (утверждение или выражение)
*                   {
*                       действие1;
*                   }
*                   else 
*                   {
*                       действие2;
*                   }
*/

namespace Lesson9
{
    class Program9
    {
        static void Main(string[] args)
        {
            bool isInfected = false;
            if (isInfected)
            {
                Console.WriteLine("Персонаж инфицирован");
            }
            else
            {
                Console.WriteLine("Персонаж здоровый, как бык))");
            }
        }
    }
}