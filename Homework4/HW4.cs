using System;

namespace Homework4
{
    public class HW4
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
            int result = MinIndexNumberArray();
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задание: Найти индекс максимального элемента массива\n");
            int result = MaxIndexNumberArray();
            Console.WriteLine($"Результат четвертой задачи: {result}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задание: Посчитать сумму элементов массива с нечетными индексами\n");
            int result = SumNumberOddIndex();
            Console.WriteLine($"Результат пятой задачи: {result}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задание: Сделать реверс массива (массив в обратном направлении)\n");
            int[] result = ReversArray();
            Console.WriteLine($"Результат шестой задачи: ");
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
        }
        public void SolveTask7()
        {
            Console.WriteLine("Задание: Посчитать количество нечетных элементов массива\n");
            int result = SumOddNumber();
            Console.WriteLine($"Результат седьмой задачи: {result}");
        }
        public void SolveTask8()
        {
            Console.WriteLine("Задание: Поменять местами первую и вторую половину массива, " +
                "например, для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312.\n");
            int[] result = SwapArray();
            Console.WriteLine($"Результат восьмой задачи: ");
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

        }
        public void SolveTask9()
        {
            Console.WriteLine("Задание: Отсортировать массив выбором(Select)\n");
            int[] result = SortSelect();
            Console.WriteLine($"Результат девятой задачи: ");
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
        }
        public void SolveTask10()
        {
            Console.WriteLine("Задание: Отсортировать массив вставками (Insert)\n");
            int[] result = SortInsert();
            Console.WriteLine($"Результат десятой задачи: ");
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public int[] FillingArray (int a)
        {
            int[] array = new int[a];
            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i]+"\t");
            }
            Console.WriteLine("\n");
            return array;
        }
        public int MinNumberArray()
        {
            int [] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int b = a[0];
            for (int i = 1; i <= a.Length; i++)
            {
                if (i == a.Length)
                {
                    break;
                }
                if (b > a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
        public int MaxNumberArray()
        {
            int [] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int b = a[0];
            for (int i = 1; i <= a.Length; i++)
            {
                if (i == a.Length)
                {
                    break;
                }
                if (b < a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
        public int MinIndexNumberArray()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int b = a[0];
            int index = 0;
            for (int i = 1; i <= a.Length; i++)
            {
                if (i == a.Length)
                {
                    break;
                }
                if (b > a[i])
                {
                    b = a[i];
                    index = i;
                }
            }
            return index;
        }
        public int MaxIndexNumberArray()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int b = a[0];
            int index = 0;
            for (int i = 1; i <= a.Length; i++)
            {
                if (i == a.Length)
                {
                    break;
                }
                if (b < a[i])
                {
                    b = a[i];
                    index = i;
                }
            }
            return index;
        }
        public int SumNumberOddIndex()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum += a[i];
            }
            return sum;
        }
        public int[] ReversArray()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int peremen = a[a.Length - 1];
            for (int i = 0; i < (a.Length / 2); i++)
            {
                peremen = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = peremen;
            }
            return a;
        }
        public int SumOddNumber()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:")); 
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        public int[] SwapArray()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int middle;
            if (a.Length % 2 == 1)
            {
                middle = (a.Length / 2) + 1;
            }
            else
            {
                middle = a.Length / 2;
            }

            for (int i = 0; i < (a.Length / 2); i++)
            {
                int peremen = a[i];
                a[i] = a[middle + i];
                a[middle + i] = peremen;


            }
            return a;
        }
        public int[] SortSelect()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int min;
            int peremen;
            for (int i = 0; i < a.Length-1; i++)
            {
                min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                peremen = a[min];
                a[min] = a[i];
                a[i] = peremen;
            }
            return a;
        }
        public int[] SortInsert()
        {
            int[] a = FillingArray(GetNumberFromUser("Введите длину массива:"));
            int peremen;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (j == a.Length - 1)
                    {
                        continue;
                    }
                    while (a[j] < a[j + 1])
                    {
                        peremen = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = peremen;
                    }
                 }
            }
            return a;
        }
    }
}
