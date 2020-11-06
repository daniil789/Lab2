using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");

            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                int[] array = CreateRandomArray(n);
                ShowArray(array);
                Console.WriteLine($"Номер минимального элемента = {FindIndexMin(array)}");
                Console.WriteLine($"Количество четных элементов массива = {FindCountEvenElements(array)}");
            }
            catch
            {
                Error();
            }
        }

        static int FindCountEvenElements(int [] array)
        {
            int countEvenElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    countEvenElement++;         
            }

            return countEvenElement;
        }

        static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static int[] CreateRandomArray(int n)
        {
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 20);

            }

            return array;
        }

        static int[] ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} - {array[i]}");

            }

            return array;
        }

        static int FindIndexMin(int[] array)
        {
            int min = int.MaxValue;
            int indexMinElement = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexMinElement = i;
                }
            }
            return indexMinElement;
        }
    }
}