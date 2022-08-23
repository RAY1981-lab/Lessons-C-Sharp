int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i=0; i<array.Length; i++)
    { }
        array[i] = random.Next(-100, 101);
    
    
    return array;
}

Console.Write("Программа сортировки массива.\r\nЭлементы присваиваются автоматически в диапазоне от -100 до 100.\r\n Введите количество элементов в массиве.  ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] massive = CreateArray(sizeArray);
