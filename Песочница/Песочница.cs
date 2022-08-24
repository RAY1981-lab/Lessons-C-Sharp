// Задача №1. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size) // метод. На входе размерность массива, на выходе заполненный массив
{
    int[] newArray = new int[size];  // Создаем массив
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;  // возвращаем массив
}

int РositivePositions(int[] massive)  // Метод выборки положительных элементов и подсчет их количества

{
    int[] mass = massive;
    int count = 0;

    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0) count += 1;
    }
    return count;
}


Console.Write("Введите размерность массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(a);
Console.WriteLine("Количество положительных элементов: " + РositivePositions(array));

