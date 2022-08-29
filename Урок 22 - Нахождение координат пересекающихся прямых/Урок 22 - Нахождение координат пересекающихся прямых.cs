double[] DataEntry()  // Метод ввода коэфициентов для уравнений прямых
{ 
    double[] dataEntry = new double[4];  // Массив из 4-х элементов: [0]-k1, [1]-k2, [2]-b1, [3]-b2
    
    Console.Write("Введите k1: ");
    dataEntry[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите b1: ");
    dataEntry[2] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите k2: ");
    dataEntry[1] = Convert.ToInt32(Console.ReadLine());
        
    Console.Write("Введите b2: ");
    dataEntry[3] = Convert.ToInt32(Console.ReadLine());

    return dataEntry;
}

string [] IntersectionPoint (double[] dataEntry)
{
    double[] coordinateDotA = new double[2];  // Массив из 2-х элементов - координаты точки пересечения (при наличии) прямых на плоскости
                                              // в виде A[0] - по оси Х, A[1] - по оси Y

    string[] coordinateDotAstr = new string[coordinateDotA.Length];  // Массив типа string. Выдаёт или координаты или признак параллельности или совпадения

    if (dataEntry[0] / dataEntry[1] != dataEntry[2] / dataEntry[3] && dataEntry[0] / dataEntry[1] == dataEntry[2] / dataEntry[3] && dataEntry[2] / dataEntry[3] !=1)
        coordinateDotAstr[0] = "parall";  // прямые параллельны

    else if (dataEntry[0] / dataEntry[1] == dataEntry[2] / dataEntry[3] && dataEntry[0] / dataEntry[1]==1 && dataEntry[2] / dataEntry[3] == 1)
         coordinateDotAstr[0] = "overlay";  // прямые совпадают друг с другом

    else if ((dataEntry[0] / dataEntry[1]) != 1)  // у Y в уравнениях нет коэффициентов => 1/1 = 1
    {
        coordinateDotA[0] = (dataEntry[3] - dataEntry[2]) /
                            (dataEntry[0] - dataEntry[1]);

        coordinateDotA[1] = (dataEntry[1] * dataEntry[2]) - (dataEntry[0] - dataEntry[3]) /
                                           ((dataEntry[1] - dataEntry[0]));
    }
    for (int i=0; i< coordinateDotA.Length; i++)
        coordinateDotAstr[i] = Convert.ToString(coordinateDotA[i]);
    return coordinateDotAstr;
}

void DataOutput()
{
   double[]  dataEntry = DataEntry();
    string[] intersectionPoint = IntersectionPoint(dataEntry);
    if (intersectionPoint[0] == "parall")
        Console.WriteLine("Прямые параллельны => не пересекаются!");
    else if (intersectionPoint[0] == "overlay")
        Console.WriteLine("Прямые совпадают друг с другом!");
    else
    {
       Console.WriteLine($"Координаты точки пересечения прямых y = {dataEntry[0]}x + {dataEntry[2]}  и  y = {dataEntry[1]}x + {dataEntry[3]} " +
                         $"в точке A[{intersectionPoint[0]}, {intersectionPoint[1]}]");
    }
}



Console.WriteLine("Программа - определятор координаты точки пересечения (при наличии) прямых на плоскости \r\n" +
                  "Уравнения прямых выглядят следующим образом:\r\n" +
                  "\ty=k1*x + b1\r\n" +
                  "\ty=k2*x + b2");

double[] dataEntry = DataEntry();
Console.WriteLine($"Получились уравнения прямых следующего вида: y = {dataEntry[0]}x + {dataEntry[2]}  и  y = {dataEntry[1]}x + {dataEntry[3]}");

DataOutput();   // хз... надо доделать!

