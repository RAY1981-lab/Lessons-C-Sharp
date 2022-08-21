using System;

/*
*Простейший калькулятор
*/

namespace Lessons14
{
    class Program14
    {
        static float VvodFloatCheck()  // метод ввода только числового значения типа float с проверкой на ошибку ввода нечисловых значений
        {
            float? chislo = 0;  // Числовая переменная типа float. В неё преобразуется строка после
                                // Convert.ToDouble. ? означет, что chislo может быть значением null
            bool uspeh = false;  // Логическая переменная. При TRUE - строка преобразована
                                 // в число и с ней проводятся дальнейшие манипуляции 
            while (uspeh == false) // Цикл. Пытаемся ввести число и только число до тех пор, пока uspeh не будет TRUE
            {
                string? inputUser = Console.ReadLine();  // В строковую переменную inputUser вводим значение с консоли
                try  // Проверка на успешность конвертации
                {
                    chislo = (float?)Convert.ToDouble(inputUser); // Преобразовываем inputUser (string) в chislo (ToDouble)
                    uspeh = true;  // Присваиваем логической переменной uspeh значение true. Цикл остановился
                }
                catch (FormatException)  // Исключение - в случае ввода некорректных данных предупреждаем об ошибке. Возврат в начало цикла
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Меняем цвет текста в консоле на Red (красный)
                    Console.WriteLine("Вы ввели что-то, которое явно не число нужного формата. Пожалуйста, повторите ввод!");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            return (float)chislo;  // Метод при успешном получении значения и конвертировании в ToDouble возвращает (выдеёт) его
        }

        static string VvodOperatorCheck()  // Метод ввода только операторов из списка (+, -, *, /) и предупреждением об ошибке
        {
            string[] operatorCase = { "+", "-", "/", "*" };  // Собственно, эти операторы. При необходимости их можно и расширить
            bool uspeh = false;  // Логическая переменная. При TRUE - пользователь ввёл только один из операторов в списке
            string? inputUser = "";  // В эту переменную пользователь вводит с клавиатуры оператор
            while (uspeh == false) // Цикл. Пытаемся ввести оператор из списка и его  до тех пор, пока uspeh не будет TRUE
            {
                inputUser = Console.ReadLine();  // В строковую переменную inputUser вводим значение с консоли
                foreach (string str in operatorCase)  // Данный оператор перечисляет элементы в списке допустимых операторов
                {
                    if ((inputUser == str) && inputUser != null)  // Если то, что вводит пользователь присутствует в списке operatorCase и не равно null
                        uspeh = true;
                }
                if (uspeh == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели что-то, которое явно не формат оператора из предложенного списка. Пожалуйста, повторите ввод!");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            return inputUser;  // Метод при успешном получении значения возвращает (выдеёт) необходимый оператор из списка
        }

        static float Сalculator(float firstNum, string oper, float secondNum)  // Метод подсчёта двух переменных в соответствии с оператором из списка
        {
            string viborOper = oper;  // присваиваем тот оператор из списка, который ранее был определён пользователем
            float chislo = 0;  // пока ответ равен 0
            switch (viborOper)  // 
            {
                case "+":
                    chislo = firstNum + secondNum;
                    break;
                case "-":
                    chislo = firstNum - secondNum;
                    break;
                case "*":
                    chislo = firstNum * secondNum;
                    break;
                case "/":
                    chislo = firstNum / secondNum;
                    break;
            }
            return (float)chislo;
        }

        // Т е л о      п р о г р а м м ы//
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Консольный калькулятор (версия 1.0)");
            Console.Write("Введите первое число: ");
            Console.ForegroundColor = ConsoleColor.Green;
            float firstNum = VvodFloatCheck();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Далее, выберите операцию: ");
            Console.WriteLine("       +     - плюс");
            Console.WriteLine("       -     - минус");
            Console.WriteLine("       /     - делить");
            Console.WriteLine("       *     - умножить");

            Console.ForegroundColor = ConsoleColor.Green;
            string oper = VvodOperatorCheck();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите второе число: ");
            Console.ForegroundColor = ConsoleColor.Green;
            float secondNum = VvodFloatCheck();

            float otvet = Сalculator(firstNum, oper, secondNum);
            Console.WriteLine("Выражение " + firstNum + " " + oper + " " + secondNum + " = " + otvet);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
