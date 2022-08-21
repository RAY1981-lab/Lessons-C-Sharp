// Создайте массив, заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чиел в массиве.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
int[] InputArray(int size)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random random = new Random();
        massive[i] = random.Next(100, 1000);
    }
    return massive;
}

int EvenCount(int[] masSort)
{
    int[] massive = masSort;
    int count = 0;
    foreach (int element in massive)
    {
        if (element % 2 == 0)
            count++;
    }
    return count;
}


Console.WriteLine("Программа автоматически заполняет массив случайными числами от 100 до 999");
int[] mas = InputArray(10);  // заполняем массив mas случайными числами от 100 до 999
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < mas.Length; i++)
    Console.Write(mas[i] + " ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("Количество чётных чиел в массиве: " + EvenCount(mas) + " шт.");

