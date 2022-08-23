// Создайте одномерный массив, заполненный случайними вещественными числами.
// Найдите разницу между максимальным и минимальным элементами массива.

double[] InputArray(int size)
{
    double[] massive = new double[size];  // Метод заполнения случайными числами (тип double).
                                          // На входе указываем размерность,
                                          // На выходе сам массив
    Random randomNum = new Random();      // Рандомизатор
    for (int i = 0; i < size; i++)
        massive[i] = (double)randomNum.NextDouble() + (int)randomNum.Next(-100, 101);  // заполняем массив вещественными числами. Как вариант можно просто умножить на 100
    return massive;
}
double[] DifferenceMaxMin(double[] massive)  // Метод выборки нечётных элементов и нахождения их суммы
                                             // На входе массив, на выходе - сумма
{
    double[] mass = massive;
    double[] solutions = new double[3];  // Создаём массив, где:
    solutions[0] = 0;  // 0 - й элемент - минимальный элемент,
    solutions[1] = 0;  // 1 - й - максимальный,
    solutions[2] = 0;  // 2 - й - разница min и мах
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < solutions[0])  // находим минимальное значение массива
            solutions[0] = mass[i];
        if (mass[i] > solutions[1])  // находим максимальное значение массива
            solutions[1] = mass[i];
    }
    solutions[2] = solutions[1] - solutions[0];  // находим разницу max и min элементов массива.
    return solutions;
}


Console.WriteLine("Программа автоматически заполняет массив из 10 элементов " +
                  "случайными вещественными числами от -100.0 до 100.0" +
                  "\r\nНайдём разницу между максимальным и минимальным элементами массива");
double[] array = InputArray(10);
double[] result = DifferenceMaxMin(array);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Получился массив: ");
for (int i = 0; i < array.Length; i++)
    Console.WriteLine("       " + array[i]);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Минимльный элемент массива: {result[0]}. \r\nМаксимальный элемент массива: {result[1]}. \r\nИх разность: {result[2]}");
Console.ForegroundColor = ConsoleColor.White;
