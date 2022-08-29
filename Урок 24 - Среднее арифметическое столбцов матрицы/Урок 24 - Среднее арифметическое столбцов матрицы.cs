//Задача 52.Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] InputArray(int m, int n, int min, int max)
{
    int[,] massive = new int[m, n];
    Random randomNum = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            massive[i, j] = (int)randomNum.Next(min, max+1);
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

double[] ArithmeticAverage(int[,] massive)  // Среднее арифметическое
{
    double[] arithmeticAverageMass = new double[massive.GetLength(1)];
    for (int j = 0; j < massive.GetLength(1); j++)
    {
    double sumColunm = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            sumColunm = sumColunm + massive[i, j];
        }
            arithmeticAverageMass[j] = Math.Round(sumColunm / massive.GetLength(0),3);
    }
    return arithmeticAverageMass;
}


Console.WriteLine("Программа находит среднее арифметическое элементов в каждом столбце матрицы, " +
                  "которая генерируется автоматически.");
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

double[] arithmeticAverage = ArithmeticAverage(inputArray);
Console.WriteLine("Среднее арифметическое ");
for (int k=0; k< arithmeticAverage.Length; k++)
    Console.Write(arithmeticAverage[k] + "\t");


Console.ForegroundColor = ConsoleColor.White;
