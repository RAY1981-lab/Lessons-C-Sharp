//Задача 50.Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет


int[,] InputArray(int m, int n, int min, int max)
{
    int[,] massive = new int[m, n];
    Random randomNum = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            massive[i, j] = (int)randomNum.Next(min, max);
    return massive;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write(massive[i, j] + "\t");
        Console.WriteLine();
    }
}

string Value(int m, int n, int[,] massive)
{
    string value;
    if (m > massive.GetLength(0) || n > massive.GetLength(1))
        value = "error";
    else value = Convert.ToString(massive[m - 1, n - 1]);
    return value;
}



Console.WriteLine("Программа, которая на на вход принимает позиции элемента\r\n" +
                  "в двумерном массиве, и возвращает значение этого элемента\r\n" +
                  "или же указание, что такого элемента нет.");
Console.WriteLine("Укажите размерность матрицы.");

Console.Write("Введите количество строк матрицы: ");
Console.ForegroundColor = ConsoleColor.Green;
int i = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введите количество столбцов матрицы: ");
Console.ForegroundColor = ConsoleColor.Green;
int j = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введите минимальное значение элементов матрицы: ");
Console.ForegroundColor = ConsoleColor.Green;
int minValue = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введите максимальное значение элементов матрицы: ");
Console.ForegroundColor = ConsoleColor.Green;
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] inputArray = InputArray(i, j, minValue, maxValue);
Console.WriteLine("");
PrintArray(inputArray);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Теперь введите координаты элемента заданного массива, " +
                  "чтобы посмотреть его значение.");
Console.Write("Введите значение i (в какой строке): ");
Console.ForegroundColor = ConsoleColor.Green;
int valX = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введите значение j (в каком столбце): ");
Console.ForegroundColor = ConsoleColor.Green;
int valY = Convert.ToInt32(Console.ReadLine());

string value = Value(valX, valY, inputArray);
if (value == "error")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Вы ввели индекс элемента, который не в матрице чисел");
}
else
{
    int valueToInt = Convert.ToInt32(value);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"В ячейке матрицы с координатой [{valX}, {valY}] находится число {valueToInt}");
}

Console.ForegroundColor = ConsoleColor.White;
