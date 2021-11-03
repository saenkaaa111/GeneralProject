using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа (A и B). " +
                "Выведите в консоль решение (5*A+B^2)/(B-A).\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 строковых значения(A и B). " +
                "Поменяйте содержимое переменных A и B местами.\n");
            string a = GetStringFromUser("Введите строковое значение A:");
            string b = GetStringFromUser("Введите строковое значение B:");
            SwapContentsOfVariable(ref a, ref b);
            Console.WriteLine($"Результат второй задачи: {a}, {b}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Пользователь вводит 2 числа(A и B). " +
                "Выведите в консоль результат деления A на B и остаток от деления.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            double result1 = GetResultOfDivision(a, b);
            double result2 = GetRemainderOfDivision(a, b);
            Console.WriteLine($"Результат третьей задачи: {result1} и {result2}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Пользователь вводит 3 не равных 0 числа(A, B и С). " +
                "Выведите в консоль решение(значение X) линейного уравнения стандартного " +
                "вида, где A * X + B = C.\n");
            int a = GetNumberFromUser("Введите число A:");
            int b = GetNumberFromUser("Введите число B:");
            int c = GetNumberFromUser("Введите число C:");
            double result = CalcEquation(a, b, c);
            Console.WriteLine($"Результат четвертой задачи: {result} ");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие " +
                "координаты 2 - х точек на координатной плоскости. Выведите уравнение прямой " +
                "в формате Y = AX + B, проходящей через эти точки.\n");
            int a = GetNumberFromUser("Введите число X1:");
            int b = GetNumberFromUser("Введите число Y1:");
            int c = GetNumberFromUser("Введите число X2:");
            int d = GetNumberFromUser("Введите число Y2:");
            string result = DeriveEquationOfStraightLine(a, b, c, d);
            Console.WriteLine($"Результат пятой задачи: {result} ");
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public double CalcFormula(int a, int b)
        {
            if (b == a)
            {
                throw new ArgumentException("Значения a и b должны быть разными");
            }
            double result = ((5 * a) + Math.Pow(b, 2)) / (b - a);
            return result;
        }
        public string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            string stringVariable = Console.ReadLine();
            return stringVariable;
        }
        public void SwapContentsOfVariable(ref string a, ref string b)
        {
            string variableReplace = a;
            a = b;
            b = variableReplace;

        }
        public int GetResultOfDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя!!");
            }
            int result = a / b;
            return result;
        }
        public double GetRemainderOfDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя!!");
            }
            double result = a % b;
            return result;
        }
        public double CalcEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя!!");
            }
            double result = (double)(c - b) / a;
            return result;
        }
        public string DeriveEquationOfStraightLine(int a, int b, int c, int d)
        {
            if (c == a)
            {
                throw new ArgumentException("Значения a и c должны быть разными");
            }
            double variableA = ((1 - a) * (d - b)) / (c - a);
            double variableB = b;
            string result;
            if (b == 0)
            {
                result = $"Y = {variableA}X";
            }
            else if (b < 0)
            {
                result = $"Y = {variableA}X - {(-1) * variableB}";
            }
            else
            {
                result = $"Y = {variableA}X + {variableB}";
            }
            return result;
        }
    }
}
