using System;

namespace Homework5
{
    public class HW5
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задание: Найти минимальный элемент массива\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            int result = GetMinNumberOfArray(array);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задание: Найти максимальный элемент массива\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            int result = GetMaxNumberOfArray(array);
            Console.WriteLine($"Результат второй задачи: {result}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задание: Найти индекс минимального элемента массива\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            int[] result = GetIndexOfMinNumberOfArray(array);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Найти индекс максимального элемента массива\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            int[] result = GetIndexOfMaxNumberOfArray(array);
            Console.WriteLine($"Результат четвертой задачи: {result}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Найти количество элементов массива, которые больше " +
                "всех своих соседей одновременно\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            int result = GetCountOfElementsThatGreaterThanNeighbors(array);
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задание: Отразите массив относительно его главной диагонали\n");
            int[,] array = Fill2ArrayWithNumber(GetNumberFromUser("Введите длину массива:"));
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            FlipArrayRelativeItsMainDiagonal(ref array);
            Console.WriteLine($"Результат шестой задачи: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j] + "\t");
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

        public int[,] Fill2ArrayWithNumber(int a)
        {
            int[,] array = new int[a,a];
            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array[i,j] = rnd.Next(-100, 100);
                }
            }
            return array;
        }

        public int GetMinNumberOfArray(int[,] a)
        {
            if (a.Length > 0)
            {
                int minNumber = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (minNumber > a[i, j])
                        {
                            minNumber = a[i, j];
                        }
                    }
                }
                return minNumber;
            }
            else { return 0; }


        }
        public int GetMaxNumberOfArray(int[,] a)
        {
            if (a.Length > 0)
            {
                int maxNumber = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (maxNumber < a[i, j])
                        {
                            maxNumber = a[i, j];
                        }
                    }
                }
                return maxNumber;
            }
            else { return 0; }
        }
        public int[] GetIndexOfMinNumberOfArray(int[,] a)
        {
            int[] index = new int[] {};
            if (a.Length > 0)
            {
                int maxNumber = a[0, 0];

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (maxNumber > a[i, j])
                        {
                            maxNumber = a[i, j];
                            index = new int[] { i, j };
                        }
                    }
                }
            }
            return index;

        }
        public int[] GetIndexOfMaxNumberOfArray(int[,] a)
        {
            int[] index = new int[] {};
            if (a.Length > 0)
            {
                int maxNumber = a[0, 0];
                
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (maxNumber < a[i, j])
                        {
                            maxNumber = a[i, j];
                            index = new int[] {i,j};
                        }
                    }
                }
            }
            return index;
        }
        public int GetCountOfElementsThatGreaterThanNeighbors(int[,] a)
        {
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i== a.GetLength(0)-1 || a[i,j]>a[i+1,j])&& 
                        (i == 0 || a[i, j] > a[i - 1, j]) &&
                        (j == a.GetLength(1)-1 || a[i, j] > a[i, j+1]) &&
                        (j == 0 || a[i, j] > a[i, j-1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public void FlipArrayRelativeItsMainDiagonal(ref int[,] a)
        {
            int variable;
            int m = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (m == a.GetLength(0))
                {
                    break;
                }
                for (int j = m; j < a.GetLength(1); j++)
                {
                    variable = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = variable;
                }
                m++;

            }
            
        }

    }
    
}
