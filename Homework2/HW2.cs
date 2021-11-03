using System;

namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа (A и B). Если A>B, " +
                "подсчитать A+B, если A=B, подсчитать A*B, если A < B, подсчитать A - B.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
            
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа(X и Y).Определить какой " +
                "четверти принадлежит точка с координатами(X, Y).\n");
            int a = GetNumberFromUser("Введите число X:");
            int b = GetNumberFromUser("Введите число Y:");
            int result = DetermineQuarter(a, b);
            string answer = result switch
            {
                0 => "Точка на оси координат",
                1 => "Первая четверть",
                2 => "Вторая четверть",
                3 => "Третья четверть",
                4 => "Четвертая четверть",
                _ => "",
            };

            Console.WriteLine($"Результат второй задачи: {answer}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Пользователь вводит 3 числа(A, B и С)." +
                "Выведите их в консоль в порядке возрастания.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int c = GetNumberFromUser("Введите число C:");
            string result = SortVariables(a, b, c);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Пользователь вводит 3 числа (A, B и С). " +
                "Выведите в консоль решение(значения X) квадратного уравнения стандартного " +
                "вида, где AX2 + BX + C = 0.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int c = GetNumberFromUser("Введите число C:");
            double[] result = GetRootsOfEquation(a, b, c);
            Console.Write($"Результат четвертой задачи: ");
            if (result.Length==0)
            {
                Console.WriteLine("Нет корней");
            }
            else if (result.Length == 1)
            {
                Console.Write ("Уравнение имеет один корень ");
            }
            else
            {
                Console.Write("Уравнение имеет два корня  ");
            }
            foreach (var item in result)
            {
                Console.Write($"{item} " ) ;
            }
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Пользователь вводит двузначное число. Выведите в " +
                "консоль прописную запись этого числа. Например при вводе “25” в консоль " +
                "будет выведено “двадцать пять”.\n");
            int a = GetNumberFromUser("Введите двузначное число:");
            string result = DisplayNumberInLetters(a);
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalcFormula(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
                return result;
            }
            else if (a == b)
            {
                result = a * b;
                return result;
            }
            else
            {
                result = a - b;
                return result;
            }
        }
        public int DetermineQuarter(int a, int b)
        {
            int result;
            if (a > 0 && b > 0)
            {
                result = 1;
            }
            else if (a < 0 && b < 0)
            {
                result = 3;
            }
            else if (a > 0 && b < 0)
            {
                result = 4;
            }
            else if (a < 0 && b > 0)
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public string SortVariables(int a, int b, int c)
        {
            string result;
            if (a > b || a > c)
            {
                if (b > c)
                {
                    if (a>b)
                    {
                        result = $"{c}, {a}, {b}";
                        return result;
                    }
                    else
                    {
                        result = $"{c}, {b}, {a}";
                        return result;
                    }
                    
                }
                else
                {
                    if (a>c)
                    {
                        result = $"{b}, {c}, {a}";
                        return result;
                    }
                    else
                    {
                        result = $"{b}, {a}, {c}";
                        return result;
                    }
                    
                }
            }
            else 
            {
                if (b > c)
                {
                    result = $"{a}, {c}, {b}";
                    return result;
                }
                else
                {
                    result = $"{a}, {b}, {c}";
                    return result;
                }
            }
            
        }
        public double[] GetRootsOfEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя!!");
            }
            double[] result;
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant > 0)
            {
                result = new double[] { (-b + Math.Sqrt(discriminant)) / (2 * a) , (-b - Math.Sqrt(discriminant)) / (2 * a) };
                return result;
            }
            else if (discriminant == 0)
            {
                result = new double[] { (-b + Math.Sqrt(discriminant)) / (2 * a) };
                return result;
            }
            else
            {
                result = new double[0];
                return result;
            }
        }
        public string DisplayNumberInLetters(int a)
        {
            int result = a % 10;
            int result2 = a / 10;
            string answer = "";
            if (a > 99)
            {
                answer = "Число должно быть двухзначное";
                return answer;
            }
            if (a >= 10 && a < 20)
            {
                answer = result switch
                {
                    0 => "Десять",
                    1 => "Одиннадцать",
                    2 => "Двенадцать",
                    3 => "Тринадцать",
                    4 => "Четырнадцать",
                    5 => "Пятнадцать",
                    6 => "Шестнадцать",
                    7 => "Семнадцать",
                    8 => "Восемнадцать",
                    9 => "Девятнадцать",
                    _ => "",
                };
                return answer;
            }
            else
            {
                answer = result2 switch
                {
                    2 => "Двадцать",
                    3 => "Тридцать",
                    4 => "Сорок",
                    5 => "Пятьдесят",
                    6 => "Шестьдесят",
                    7 => "Семьдесят",
                    8 => "Восемьдесят",
                    9 => "Девяносто",
                    _ => "",

                };
                if (answer!="")
                {
                    answer = answer + " ";
                }
                answer = result switch
                {
                    0 => answer,
                    1 => answer + "один",
                    2 => answer + "два",
                    3 => answer + "три",
                    4 => answer + "четыре",
                    5 => answer + "пять",
                    6 => answer + "шесть",
                    7 => answer + "семь",
                    8 => answer + "восемь",
                    9 => answer + "девять",
                    _ => "",
                };
                return answer;
            }
            
        }
    }
}