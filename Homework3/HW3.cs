using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа(A и B). Возвести " +
                "число A в степень B.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int result = Elevate(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Вывести все числа" +
                " от 1 до 1000, которые делятся на A.\n");
            int a = GetNumberFromUser("Введите число A:");
            string result = DivisionByNumber(a);
            Console.WriteLine($"Результат второй задачи: {result}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Найдите количество " +
                "положительных целых чисел, квадрат которых меньше A.\n");
            int a = GetNumberFromUser("Введите число A:");
            int result = SearchNumbers(a);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Вывести наибольший делитель " +
                "(кроме самого A) числа A.\n");
            int a = GetNumberFromUser("Введите число A:");
            int result = DevisorSearch(a);
            Console.WriteLine($"Результат четвертой задачи: {result}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа (A и B). Вывести сумму всех " +
                "чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что " +
                "при вводе B может оказаться меньше A).\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int result = DevisorBySeven(a, b);
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи. " +
                "В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое " +
                "и второе считаются равными 1.\n");
            int a = GetNumberFromUser("Введите число N:");
            int result = FibonacciRange(a);
            Console.WriteLine($"Результат шестой задачи: {result}");
        }
        public void SolveTask7()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Найти их наибольший общий делитель " +
                "используя алгоритм Евклида.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:"); 
            int result = EuclideanAlgorithm(a, b);
            Console.WriteLine($"Результат седьмой задачи: {result}");
        }
        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, которое является " +
                "кубом целого числа N. Найдите число N методом половинного деления.\n");
            int a = GetNumberFromUser("Введите число:");
            int result = HalfDivisionMethod(a);
            Console.WriteLine($"Результат восьмой задачи: {result}");
        }
        public void SolveTask9()
        {
            Console.WriteLine("Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.\n");
            int a = GetNumberFromUser("Введите число:");
            int result = SearchOddNumbers(a);
            Console.WriteLine($"Результат девятой задачи: {result}");
        }
        public void SolveTask10()
        {
            Console.WriteLine("Пользователь вводит 1 число.Найти число, которое является зеркальным " +
                "отображением последовательности цифр заданного числа, например, задано число 123, " +
                "вывести 321.\n");
            int a = GetNumberFromUser("Введите число:");
            string result = Mirror(a);
            Console.WriteLine($"Результат десятой задачи: {result}");
        }
        public void SolveTask11()
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N). Выведите " +
                "числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных\n");
            int a = GetNumberFromUser("Введите число:");
            string result = OutputRange(a);
            Console.WriteLine($"Результат одиннадцатой задачи: {result}");
        }
        public void SolveTask12()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Сообщите, есть ли в написании двух " +
                "чисел одинаковые цифры.Например, для пары 123 и 3456789, ответом будет " +
                "являться “ДА”, а, для пары 500 и 99 - “НЕТ”.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:"); 
            string result = SearchIdenticalDigits(a, b);
            Console.WriteLine($"Результат двеннадцатой задачи: {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int Elevate(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            return result;
        }   
        public string DivisionByNumber(int a)
        {
            string result ="";
            for (int i = 1; i < 1000; i++)
            {
                if (i % a == 0)
                {
                    result += $"{i}\t";
                }
            }
            return result;
        }
        public int SearchNumbers(int a)
        {
            int quantity = 0;
            for (int i = 1; i < a; i++)
            {
                if (Math.Pow(i, 2) < a)
                {
                    quantity++;
                }
            }
            return quantity;
        }
        public int DevisorSearch(int a)
        {
            int result = 0;
            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    return result;
                }
            }
            return result;
        }
        public int DevisorBySeven(int a, int b)
        {
            int sum = 0;
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum+=i;
                    }
                }
                return sum;
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum+=i;
                    }
                }
                return sum;
            }
        }
        public int FibonacciRange(int a)
        {
            int numberNMinOne = 1;
            int numberNMinTwo = 1;
            int result;
            int counter = 3;
            do
            {
                result = numberNMinOne + numberNMinTwo;
                numberNMinOne = numberNMinTwo;
                numberNMinTwo = result;
                counter++;
            } while (counter != a + 1);
            return result;
        }
        public int EuclideanAlgorithm(int a, int b)
        {
            int account = 0;
            int peremen;
            if (a < b)
            {
                peremen = a;
                a = b;
                b = peremen;
            }
            while (a > b)
            {
                a -= b;
                account++;
                if (b > a)
                {
                    peremen = a;
                    a = b;
                    b = peremen;
                }
            }
            return a;
        }
        public int HalfDivisionMethod(int a)
        {
            int x = a;
            int i = 0;
            if (a % 2 == 1)
            {
                a -= 1;
                i++;
            }
            int center = a / 2;
            while (center * center * center != x)
            {
                if (center % 2 == 1)
                {
                    center -= 1;
                    i++;
                }
                if (i >= 5)
                {
                    center += 3;
                    continue;
                }
                center /= 2;
            }
            return center;
        }
        public int SearchOddNumbers(int a)
        {
            int numberA = Math.Abs(a);
            int i = 0;
            int b = numberA;
            while (numberA != 0)
            {
                numberA /= 10;
                if (b % 2 == 1)
                {
                    i++;
                }
                b = numberA;
            }
            return i;
        }
        public string Mirror(int a)
        {
            int numberA = Math.Abs(a);
            int b = numberA;
            string mirror = "";
            while (numberA != 0)
            {
                b %= 10;
                numberA /= 10;
                mirror += b;
                b = numberA;
            }
            return mirror;
        }
        public string OutputRange(int a)
        {
            string result = "";
            for (int i = 1; i < a + 1; i++)
            {
                int cycle = i;
                int output = i;
                int even = 0;
                int odd = 0;
                int b = i % 10;
                while (i != 0)
                {
                    if (b % 2 == 1)
                    {
                        odd += b;
                    }
                    else
                    {
                        even += b;
                    }
                    i /= 10;
                    b = i % 10;
                }
                if (even > odd)
                {
                    result += $"{output}\t";
                }
                i = cycle;
            }
            return result;
        }
        public string SearchIdenticalDigits(int a, int b)
        {
            int x = a;
            string result = "";
            while (b != 0)
            {
                while (a != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        result = "Да";
                        break;
                    }
                    a /= 10;
                }
                b /= 10;
                a = x;
            }
            if (result == "")
            {
                result = "Нет";
            }
            return result;
        }
    }
}
