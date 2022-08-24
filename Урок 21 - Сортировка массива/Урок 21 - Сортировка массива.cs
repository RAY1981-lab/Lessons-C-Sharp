int[] CreateArray(int size)  // Метод заполнения массива случайными целыми числами от -100 до 100
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-100, 101);
    return array;
}

int[] BubbleSortArray(int[] array)  // Сортировка массива пузырьковым методом
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
    return array;
}


int[] MergeSortArray(int[] array)  // Сортировка массива методом слияния
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
    return array;
}





Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Программа сортировки массива.\r\nЭлементы присваиваются автоматически в диапазоне от -100 до 100.\r\nВведите количество элементов в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] massive = CreateArray(sizeArray);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Начальный вариант массива:");
for (int i = 0; i < massive.Length; i++)
    Console.Write(massive[i] + " ");
Console.WriteLine();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Сортировка массива пузырьковым методом:");
int[] bubble = BubbleSortArray(massive);
for (int i = 0; i < massive.Length; i++)
    Console.Write(bubble[i] + " ");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Сортировка массива пузырьковым методом:");
int[] merge = MergeSortArray(massive);
for (int i = 0; i < massive.Length; i++)
    Console.Write(bubble[i] + " ");



Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;