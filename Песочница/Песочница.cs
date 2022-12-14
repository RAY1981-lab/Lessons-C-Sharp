//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] Array2D (int numXY)
{
    int[,] array2D = new int[numXY, numXY];  // Определяем количество сторон
    int numCell = 1;                         // Переменная, которая заполняет элемент матрицы
    int i = 0;
    int j = 0;

    while (numCell <= array2D.GetLength(0) * array2D.GetLength(1))
    {
        array2D[i, j] = numCell;
        numCell++;
        if (i + j < array2D.GetLength(1) - 1 && i <= j + 1)  // Заполняем вниз
            j++;
        else if (i + j >= array2D.GetLength(0) - 1 && i < j)  // Заполняем вправо
            i++;
        else if (i + j > array2D.GetLength(1) - 1 && i >= j)  // Заполняем вверх
            j--;
        else  // Заполняем влево
            i--;
    }
    return array2D;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write(array[i, j] + "\t");
            else Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


////--------------------------О С Н О В Н А Я       П Р О Г Р А М М А------------------------
Console.WriteLine("Программа, которая заполнит спирально квадратный массив со сторонами от 2 до 10 (допустим, 4 х 4).");

Console.Write("Введите количество ячеек по осям Х и Y: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 1 || n > 10)  // Условие "оптимального" заполнения числа ячеек по оси
{
    if (n <= 1)
    {
        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 10): ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    if (n > 10)
    {
        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 10): ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}


int[,] array2D = Array2D(n);
PrintArray2D(array2D);



















































////Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
////Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
////Массив размером 2 x 2 x 2
////66(0,0,0) 25(0, 1, 0)
////34(1, 0, 0) 41(1, 1, 0)
////27(0, 0, 1) 90(0, 1, 1)
////26(1, 0, 1) 55(1, 1, 1)


//int[,,] RandomArray3D(int[,,] array3D)
//{
//    int[] vector = new int[array3D.GetLength(0) *  // Формируем временный массив векторного типа.В него
//                           array3D.GetLength(1) *  // помещаем количество всех ячеек из 3-хмерного массиве
//                           array3D.GetLength(2)]; 
//    int number;
//    for (int i = 0; i < vector.GetLength(0); i++)  // по оси Х
//    {
//        vector[i] = new Random().Next(10, 100);  // Из расчёта, что максимальный
//                                                 // размер массива 4х4х4 = 56. (5х5х5 = 125  -
//                                                 // не подходит, т.к. число уже трёзначное)
//                                                 // Допустим, числа положительные
//        number = vector[i];
//        if (i >= 1)
//        {
//            for (int j = 0; j < i; j++)  // по оси Y
//            {
//                while (vector[i] == vector[j])
//                {
//                    vector[i] = new Random().Next(10, 100);
//                    j = 0;
//                    number = vector[i];
//                }
//                number = vector[i];
//            }
//        }
//    }
//    int count = 0;
//    for (int x = 0; x < array3D.GetLength(0); x++)
//       for (int y = 0; y < array3D.GetLength(1); y++)
//           for (int z = 0; z < array3D.GetLength(2); z++)
//           {
//               array3D[x, y, z] = vector[count];
//               count++;
//           }
//    return array3D;
//}

//void PrintArray3D(int[,,] array3D)
//{
//    for (int i = 0; i < array3D.GetLength(0); i++)
//    {
//        for (int j = 0; j < array3D.GetLength(1); j++)
//        {
//            for (int k = 0; k < array3D.GetLength(2); k++)
//                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) {" "} \t");
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}


////--------------------------О С Н О В Н А Я       П Р О Г Р А М М А------------------------
//Console.WriteLine("Программа создаёт трёххмерный массив с неповторяющимися двухзначными числами." +
//                  "\r\n\tПострочно выводит массив, добавляя индексы каждого элемента.");
//Console.WriteLine("Укажите размерность матрицы.");

//Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
//int x = Convert.ToInt32(Console.ReadLine());
//while (x <= 1 || x > 4)  // Условие "оптимального" заполнения числа ячеек по оси
//{
//    if (x <= 1)
//    {
//        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
//        x = Convert.ToInt32(Console.ReadLine());
//    }
//    if (x > 4)
//    {
//        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Х (желательно в пределах от 2 до 4): ");
//        x = Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.Write("Введите количество ячеек по оси Y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//while (y <= 1 || y > 4)  // Условие "оптимального" заполнения числа ячеек по оси 
//{
//    if (y <= 1)
//    {
//        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
//        y = Convert.ToInt32(Console.ReadLine());
//    }
//    if (y > 4)
//    {
//        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Y (желательно в пределах от 2 до 4): ");
//        y = Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.Write("Введите количество ячеек по оси Z: ");
//int z = Convert.ToInt32(Console.ReadLine());
//while (z <= 1 || z > 4)  // Условие "оптимального" заполнения числа ячеек по оси
//{
//    if (z <= 1)
//    {
//        Console.WriteLine("По-братски, задай значение по-больше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
//        z = Convert.ToInt32(Console.ReadLine());
//    }
//    if (z > 4)
//    {
//        Console.WriteLine("По-братски, задай значение по-меньше, но в пределах разумного");
//        Console.Write("Введите количество ячеек по оси Z (желательно в пределах от 2 до 4): ");
//        z = Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.WriteLine();
//int[,,] array3D = new int[x,y,z];
//int[,,] randomArray3d = RandomArray3D(array3D);
//PrintArray3D(randomArray3d);