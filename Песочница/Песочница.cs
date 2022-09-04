//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)




int[,,] Array3D(int length, int width, int height)
{
    int[,,] array = new int[length, width, height];
    Random randomNum = new Random();
    for (int i = 0; i < length; i++)
        for (int j = 0; j < width; j++)
            for (int k = 0; k < height; k++)
                array[i, j, k] = (int)randomNum.Next(0,344);  // Из расчёта, что максимальный
                                                              // размер массива 7х7х7 = 343.
                                                              // Допустим, числа положительные


            //{  // Тут будет тройной цикл по поиску одинаковых элементов
            //    for (int a = 0; a < height; a++)
            //        for (int b = 0; b < width; b++)
            //            for (int c = 0; c < height; c++)
            //            {
            //                if (array[i, j, k] == array[a, b, c])
            //                { 
            //                    //a = 0;
            //                    //b = 0;
            //                    //c = 0;
            //                }
            //                else 
            //            }
            //}
    return array;
}



void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) {" "} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


//--------------------------О С Н О В Н А Я       П Р О Г Р А М М А------------------------
Console.WriteLine("Программа создаёт 3-хмерный массив с неповторяющимися элементами. " +
                  "будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("Укажите размерность матрицы.");

Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
int i = Convert.ToInt32(Console.ReadLine());
while (i <= 1 || i > 4)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (i <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
        i = Convert.ToInt32(Console.ReadLine());
    }
    if (i > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
        i = Convert.ToInt32(Console.ReadLine());
    }
}


Console.Write("Введите количество ячеек по оси Y: ");
int j = Convert.ToInt32(Console.ReadLine());
while (j <= 1 || j > 4)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (j <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
        j = Convert.ToInt32(Console.ReadLine());
    }
    if (j > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
        j = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите количество ячеек по оси Z: ");
int k = Convert.ToInt32(Console.ReadLine());
while (k <= 1 || k > 4)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (k <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (k > 4)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
        k = Convert.ToInt32(Console.ReadLine());
    }
}

int[,,] array3D = Array3D(i,j,k);

PrintArray3D(array3D);