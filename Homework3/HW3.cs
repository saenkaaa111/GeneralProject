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
            int result = RaiseNumberToPower(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Вывести все числа" +
                " от 1 до 1000, которые делятся на A.\n");
            int a = GetNumberFromUser("Введите число A:");
            string result = GetNumbersThatDivisibleByNumberFromUser(a);
            Console.WriteLine($"Результат второй задачи: {result}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Найдите количество " +
                "положительных целых чисел, квадрат которых меньше A.\n");
            int a = GetNumberFromUser("Введите число A:");
            int result = GetCountOfNumbersWithSquareLessThanNumberFromUser(a);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Пользователь вводит 1 число (A). Вывести наибольший делитель " +
                "(кроме самого A) числа A.\n");
            int a = GetNumberFromUser("Введите число A:");
            int result = GetGreatestDivisor(a);
            Console.WriteLine($"Результат четвертой задачи: {result}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа (A и B). Вывести сумму всех " +
                "чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что " +
                "при вводе B может оказаться меньше A).\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int result = GetSumNumbersWhichDivisibleBySeven(a, b);
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи. " +
                "В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое " +
                "и второе считаются равными 1.\n");
            int a = GetNumberFromUser("Введите число N:");
            int result = GetNumberOfFibonacciRange(a);
            Console.WriteLine($"Результат шестой задачи: {result}");
        }
        public void SolveTask7()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Найти их наибольший общий делитель " +
                "используя алгоритм Евклида.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:"); 
            int result = GetGreatestCommonDivisorUsingEuclidAlgorithm(a, b);
            Console.WriteLine($"Результат седьмой задачи: {result}");
        }
        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, которое является " +
                "кубом целого числа N. Найдите число N методом половинного деления.\n");
            int a = GetNumberFromUser("Введите число:");
            int result = GetNumberUsingHalfDivisionMethod(a);
            Console.WriteLine($"Результат восьмой задачи: {result}");
        }
        public void SolveTask9()
        {
            Console.WriteLine("Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.\n");
            int a = GetNumberFromUser("Введите число:");
            int result = GetOddNumbers(a);
            Console.WriteLine($"Результат девятой задачи: {result}");
        }
        public void SolveTask10()
        {
            Console.WriteLine("Пользователь вводит 1 число.Найти число, которое является зеркальным " +
                "отображением последовательности цифр заданного числа, например, задано число 123, " +
                "вывести 321.\n");
            int a = GetNumberFromUser("Введите число:");
            string result = GetNumberMirrored(a);
            Console.WriteLine($"Результат десятой задачи: {result}");
        }
        public void SolveTask11()
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N). Выведите " +
                "числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных\n");
            int a = GetNumberFromUser("Введите число:");
            string result = GetNumbersWhereSumOfEvenDigitsIsGreaterThanOdd(a);
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
        public int RaiseNumberToPower(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            return result;
        }   
        public string GetNumbersThatDivisibleByNumberFromUser(int a)
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
        public int GetCountOfNumbersWithSquareLessThanNumberFromUser(int a)
        {
            int count = 0;
            for (int i = 1; i < a; i++)
            {
                if (Math.Pow(i, 2) < a)
                {
                    count++;
                }
            }
            return count;
        }
        public int GetGreatestDivisor(int a)
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
        public int GetSumNumbersWhichDivisibleBySeven(int a, int b)
        {
            int sum = 0;
            if (a < b)
            {
                Swap(ref a, ref b);
            }
            for (int i = b; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum+=i;
                    }
                }
                return sum;
            
        }
        public void Swap(ref int a, ref int b)
        {
            int variable = a;
            a = b;
            b = variable;
           
        }
        public int GetNumberOfFibonacciRange(int a)
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
        public int GetGreatestCommonDivisorUsingEuclidAlgorithm(int a, int b)
        {
            int count = 0;
            if (a < b)
            {
                Swap(ref a, ref b);
            }
            while (a > b)
            {
                a -= b;
                count++;
                if (b > a)
                {
                    Swap(ref a, ref b);
                }
            }
            return a;
        }
        public int GetNumberUsingHalfDivisionMethod(int a)
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
        public int GetOddNumbers(int a)
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
        public string GetNumberMirrored(int a)
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
        public string GetNumbersWhereSumOfEvenDigitsIsGreaterThanOdd (int a)
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
