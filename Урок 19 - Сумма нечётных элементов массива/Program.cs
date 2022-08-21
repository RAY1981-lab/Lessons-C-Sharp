// Создайте одномерный массив, заполненный случайними числами.
// Найдите сумму элементов, стоящих на нечётных позициях

int[] InputArray(int size)
{
    int[] massive = new int[size];  // Метод заполнения случайными числами (тип int).
                                    // На входе указываем размерность,
                                    // На выходе сам массив
    Random randomNum = new Random();  // Рандомизатор
    for (int i = 0; i < size; i++)
        massive[i] = randomNum.Next(-1000, 1001);
    return massive;
}
int SumOddPositions(int[] massive)  // Метод выборки нечётных элементов и нахождения их суммы
                                    // На входе массив, на выходе - сумма
{
    int[] mass = massive;
    int sum = 0;
    Console.Write("Выборка элементов массива на нечётных позициях: ");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
        sum = sum + mass[i];
        i++;
    }
    Console.WriteLine();
    return sum;
}

Console.WriteLine("Программа автоматически заполняет массив из 10 элементов " +
                  "случайными числами от -1000 до 1000. " +
                  "\r\nНайдём сумму элементов, стоящих на нечётных позициях");
int[] array = InputArray(10);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Получился массив: ");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + SumOddPositions(array));
Console.ForegroundColor = ConsoleColor.White;