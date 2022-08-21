//using System;

// * работа с массивами
//*/

//namespace Lessons
//{
//    class Program1
//    {
//        static void Mas1()
//        {
//            int[] intArray1 = new int[3]; // Объявление массива 2-й авриант
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
//                intArray1[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("Получившийся массив выводим на экран:");
//            for (int i = 0; i < 3; i++)
//                Console.Write(intArray1[i] + " ");
//            Console.WriteLine();
//        }

//        static void Mas2()
//        {
//            string[] strArray2 = { "Понедельник", "Вторник", "Среда", "Четверг",
//                                   "Пятница", "Суббота", "Воскресение"};
//            for (int i = 0; i < strArray2.Length; i++)
//                Console.WriteLine(strArray2[i]);
//        }

//        static void Mas3()  // матрица (двумерный массив)
//        {
//            int[,] strArray3 = new int [3,3];

//            for (int i = 0; i < strArray3.Length; i++)
//                for (int j = 0; j < strArray3.Length; j++)
//                {
//                    Console.WriteLine("Введите элемент " + i + "-й строки " + j + "-го столбца");
//                    strArray3[i,j] = Convert.ToInt32(Console.ReadLine());
//                }
//            for (int i = 0; i<strArray3.Length; i++)
//                for (int j = 0; j<strArray3.Length; j++)
//                    Console.WriteLine(strArray3[i,j]);
//        }



//        static void Main(string[] args)
//        {
//            Mas1();
//            Mas2();
//            Mas3();

//        }
//    }
//}

// //Задача №1.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// //3, 5 -> 243 (3⁵)
// //2, 4-> 16

//// Вариант №1.При помощи формулы
// double DegreeNumber (double x, double y)  // int x - число; int y- степень
// {
//    double a = Math.Pow(x, y);   // возводим в степень при помощи формулы
//    return a;
// }

//Console.WriteLine("Простой калькулятор для определения числа a в степени n");
//Console.Write("Введите число a: ");
//double digit = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите в какую степень будем возводить: ");
//double number = Convert.ToInt32(Console.ReadLine());
//double resultat = DegreeNumber(digit, number);
//Console.WriteLine($"Ответ: число {digit} в степени {number} равно {resultat}");


//// Вариант №2. через цикл for
//int DegreeNumber(int x, int y) // метод для определения числа х в степени у
//{
//    int result = 1;
//    for (int i = 1; i <= y; i++) // при помощи цикла for возводим число в степень.
//        result = result * x;
//    return result;
//}

//Console.WriteLine("Простой калькулятор для определения числа a в степени n");
//Console.Write("Введите число a: ");
//int digit = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите в какую степень будем возводить: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int resultat = DegreeNumber(digit, number);
//Console.WriteLine($"Ответ: число {digit} в степени {number} равно {resultat}");


//// Вариант №3. через цикл while
// int DegreeNumber(int x, int y)
//{
//    int i = 1;
//    int result = 1;
//    while (i <= y)
//    {
//        result = result * x;
//        i++;
//    }
//    return result;
//}

//Console.WriteLine("Простой калькулятор для определения числа a в степени n");
//Console.Write("Введите число a: ");
//int digit = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите в какую степень будем возводить: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int resultat = DegreeNumber(digit, number);
//Console.WriteLine($"Ответ: число {digit} в степени {number} равно {resultat}");





//// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//// 452 -> 11
//// 82 -> 10
//// 9012 -> 12
//// Вариант №1. при помощи цикла for

//int Count(int number)
//{
//    int size = 0;
//    int score = 0;
//    int counter = Convert.ToString(number).Length;

//    for (int i = 0; i < counter; i++)
//    {
//        score = number - number % 10;
//        size = size + (number - score);
//        number = number / 10;
//    }
//    return size;
//}

//Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = Count(num);
//Console.WriteLine("Сумма цифр в числе = " +sum);



// Вариант №2. через цикл while
//int Count(int number)
//{
//    int size = 0;
//    int score = 0;
//    int counter = Convert.ToString(number).Length;
//    int i = 0;
//    while (i < counter)
//    {
//        score = number - number % 10;
//        size = size + (number - score);
//        number = number / 10;
//        i++;
//    }
//    return size;
//}

//Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = Count(num);
//Console.WriteLine("Сумма цифр в числе = " + sum);





//// Задача №3.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//// 6, 1, 33-> [6, 1, 33]

//void InputOutputArray()
//{
//    int[] intArray1 = new int[8];
//    for (int i = 0; i < 8; i++)
//    {
//        Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
//        intArray1[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    Console.WriteLine("Получившийся массив выводим на экран:");
//    for (int i = 0; i < 8; i++)
//        Console.Write(intArray1[i] + " ");
//    Console.WriteLine();
//}

//Console.WriteLine("Программа, которая задаёт массив из 8 элементов и выводит их на экран.");
//InputOutputArray();

//Console.WriteLine();



//// Вариант 2
//static int[] InputArray(int n)
//{
//    int[] massive = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//        Console.WriteLine("Введите " + (i + 1) + "-й элемент массива: ");
//        massive[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    return massive;
//}

//Console.WriteLine("Программа, которая задаёт массив из 8 элементов и выводит их на экран.");
//int[] nums = InputArray(8);
//Console.WriteLine("Получившийся массив выводим на экран:");
//foreach (int i in nums)
//    Console.Write(i + " ");









