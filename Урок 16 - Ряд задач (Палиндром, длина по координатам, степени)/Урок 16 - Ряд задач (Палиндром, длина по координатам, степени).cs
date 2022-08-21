//Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//           Программа с проверкой на то, что введённой число будет 5-тизначным
Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int inputCheck()  // Метод ввода только 5-ти символов с проверкой
{
    bool flag = false;  // Логическая переменная. Цикл ниже будет работать до тех пор, пока flag = false
    int num = 0;
    string str = "";
    while (flag == false)  // Тот самый цикл
    {
        num = Convert.ToInt32(Console.ReadLine());  // Вводим данные
        str = Convert.ToString(num);
        if (str.Length == 5) flag = true;  // цикл оканчивается, если длина = 5. 
        else Console.WriteLine("Вы ввели не 5 символов или цифр. Пожалуйста, повторите ввод: "); // Иначе сообщение об ошибке
    }
    return num;  // Возвращаем уже проверенное число
}

void Palindrome(string strPal)                               // Метод типа void. Ничего не отдаёт. Просто выполняет код.
{
    if (strPal[0] == strPal[4] && strPal[1] == strPal[3])    //Условие. Сравниваем равны ли цифры (1 и 5, 2 и 4)
        Console.WriteLine($"Число {strPal} - явлется палиндромным");   // Если равны выводим на консоль, что число палидромное
    else
        Console.WriteLine($"Число {strPal} - не является палиндровным");  // Иначе - Не полидровное
}


Console.WriteLine("Ввeдите пятизначное число: ");             // Вводим то число, которое будем проверять на палидромность.
int number = inputCheck();
string str = Convert.ToString(number);
Palindrome(str);






// Задача №2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек \r\nи находит расстояние между ними в 3D пространстве.");
//double Length(double X1, double Y1, double Z1,  // Метод нахождение длины отрезка. На входе 2 координаты
//              double X2, double Y2, double Z2)
//{
//    double len1 = Math.Sqrt(Math.Pow(X2 - X1, 2) +  // Вводим формулу нахождения координат двух точек
//                            Math.Pow(Y2 - Y1, 2) +  // и нахождения расстояния между ними
//                            Math.Pow(Z2 - Z1, 2));  // в трёхмернов пространстве
//    return len1;
//}
//Console.Write("Введите координату Х точки А ");
//double xA = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату У точки А ");
//double yA = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату Z точки А ");
//double zA = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату Х точки В ");
//double xB = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату У точки В ");
//double yB = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату Z точки B ");
//double zB = Convert.ToInt32(Console.ReadLine());

//double len = Length(xA, yA, zA, 
//                    xB, yB, zB);
//Console.WriteLine("Длина отрезка равна " + len);







//// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//void QardN(int n)  // Метод типа viod. Ничего не отдаёт. Просто выполняет код.
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;  // Меняем цвет. Для красоты))
//    for (int i = 1; i <= n; i++)  // цикл for([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
//        Console.Write(Math.Pow(i, 3) + " ");  // Ввыводим таблицу кубов
//}
//Console.Write("Программа для вывода ряда чисел в 3-й степени от 1 до N. \r\nВведите натуральное число N: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ряд чисел в 3-й степени от 1 до " + num + " выглядит: ");
//QardN(num);
//Console.ForegroundColor = ConsoleColor.White;
