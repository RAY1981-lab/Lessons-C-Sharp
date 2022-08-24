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


double[] IntersectionPoint (double[] dataEntryMassive)
{
    double[] dataEntryMassiveWork = dataEntryMassive;
    double[] coordinateDotA = new double[2];  // Массив из 2-х элементов - координаты точки пересечения (при наличии) прямых на плоскости
                                              // в виде A[0] - по оси Х, A[1] - по оси Y

    do
    {
        if ((dataEntryMassiveWork[0] / dataEntryMassiveWork[1]) != (dataEntryMassiveWork[2] / dataEntryMassiveWork[3]))
        {
            Console.WriteLine("Прямые параллельны => не пересекаются!");
            break;
        }
        else if ((dataEntryMassiveWork[0] / dataEntryMassiveWork[1]) == (dataEntryMassiveWork[2] / dataEntryMassiveWork[3]))
        {
            Console.WriteLine("Прямые совпадают друг с другом!");
            break;
        }
        else if ((dataEntryMassiveWork[0] / dataEntryMassiveWork[1]) == 1)  // у Y в уравнениях нет коэффициентов => 1/1 = 1
        {
            coordinateDotA[0] = (dataEntryMassiveWork[3] - dataEntryMassiveWork[2]) /
                                (dataEntryMassiveWork[0] - dataEntryMassiveWork[1]);

            coordinateDotA[1] = (dataEntryMassiveWork[1] * dataEntryMassiveWork[2]) - (dataEntryMassiveWork[0] - dataEntryMassiveWork[3]) /
                                                            ((dataEntryMassiveWork[1] - dataEntryMassiveWork[0]));
            return coordinateDotA;
        }
    }
    while (false);
}


Console.WriteLine("Программа - определятор координаты точки пересечения (при наличии) прямых на плоскости \r\n" +
                  "Уравнения прямых выглядят следующим образом:\r\n" +
                  "\ty=k1*x + b1\r\n" +
                  "\ty=k2*x + b2");

double[] dataEntry = DataEntry();
Console.WriteLine($"Получились уравнения прямых следующего вида: y = {dataEntry[0]}x + {dataEntry[2]}  и  y = {dataEntry[1]}x + {dataEntry[3]}");


