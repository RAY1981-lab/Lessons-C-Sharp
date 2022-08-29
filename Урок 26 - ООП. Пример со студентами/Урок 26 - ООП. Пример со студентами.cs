using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// ООП
// Класс
// Объект класса


namespace LessonsStudent
{
    class Student
    {
        public Gu;
        public int y;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point pointDod1 = new Point();
            pointDod1.x = 5;
            pointDod1.y = 5;
            pointDod1.color = Color.Green;

            Point pointDod2 = new Point();
            pointDod2.x = 3;
            pointDod2.y = 8;
            pointDod2.color = Color.White;

            Console.WriteLine($"У точки {pointDod1.color} координата ({pointDod1.x}, {pointDod1.y})");
            Console.WriteLine($"У точки {pointDod2.color} координата ({pointDod2.x}, {pointDod2.y})");

        }
    }
}