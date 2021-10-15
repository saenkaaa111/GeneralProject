using System;

namespace Homework5
{
    public class HW5
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задание: Найти минимальный элемент массива\n");
            int result = MinNumberArray();
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Найти максимальный элемент массива\n");
            int result = MaxNumberArray();
            Console.WriteLine($"Результат второй задачи: {result}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Найти индекс минимального элемента массива\n");
            string result = MinNumberIndexArray();
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Найти индекс максимального элемента массива\n");
            string result = MaxNumberIndexArray();
            Console.WriteLine($"Результат четвертой задачи: {result}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Найти количество элементов массива, которые больше " +
                "всех своих соседей одновременно\n");
            int result = FindNumberElementsThatGreaterThanNeighbors();
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задание: Отразите массив относительно его главной диагонали\n");
            int[,] result = FlipArrayRelativeItsMainDiagonal();
            Console.WriteLine($"Результат шестой задачи: ");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public int[,] Filling2Array(int a)
        {
            int[,] array = new int[a,a];
            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array[i,j] = rnd.Next(-100, 100);
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
            return array;
        }

        public int MinNumberArray()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int minNumber = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (minNumber > a[i, j])
                    {
                        minNumber = a[i, j];
                    }
                }
            }
           return minNumber;
        }
        public int MaxNumberArray()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int maxNumber = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (maxNumber < a[i, j])
                    {
                        maxNumber = a[i, j];
                    }
                }
            }
           return maxNumber;
        }
        public string MinNumberIndexArray()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int minNumber = a[0, 0];
            string index = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (minNumber > a[i, j])
                    {
                        minNumber = a[i, j];
                        index = $"{i},{j}";
                    }
                }
            }
            return index;
        }
        public string MaxNumberIndexArray()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int maxNumber = a[0, 0];
            string index = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (maxNumber < a[i, j])
                    {
                        maxNumber = a[i, j];
                        index = $"{i},{j}";
                    }
                }
            }
            return index;
        }
        public int FindNumberElementsThatGreaterThanNeighbors()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if ((i== a.GetLength(0)-1 || a[i,j]>a[i+1,j])&& 
                        (i == 0 || a[i, j] > a[i - 1, j]) &&
                        (j == a.GetLength(0)-1 || a[i, j] > a[i, j+1]) &&
                        (j == 0 || a[i, j] > a[i, j-1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int[,] FlipArrayRelativeItsMainDiagonal()
        {
            int[,] a = Filling2Array(GetNumberFromUser("Введите длину массива:"));
            int peremen;
            int m = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (m == a.GetLength(0))
                {
                    break;
                }
                for (int j = m; j < a.GetLength(0); j++)
                {
                    peremen = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = peremen;
                }
                m++;

            }
            return a;
        }

    }
    
}
