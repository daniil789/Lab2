using System;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n...");

            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                int minNum = int.MaxValue;
                int countEvenElements = 0;
                Console.WriteLine("Вводите числа...");

                for (int i = 0; i < n; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num < minNum)
                        minNum = num;

                    if (num % 2 == 0)
                        countEvenElements++;

                }
                Console.WriteLine($"Минимальный элменет последовательности = {minNum}");
                Console.WriteLine($"Количество четных элементов в последовательности = {countEvenElements}");
                Console.WriteLine($"S = 1/3^2 + 1/5^2 + 1/7^2... + 1/(2n+1)^2 = {Task3(n)}");
            }
            catch
            {
                Error();
            }
        }

        public static int FindCountEvenElements(int[] array)
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

        public static int FindIndexMin(int[] array)
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

        public static double Task3(int n)
        {
            double s = 0;
            double denominator = 3;

            for (int i = 0; i < n; i++)
            {
                s += 1 / Math.Pow(denominator, 2);
            }

            s += 1 / Math.Pow(2 * n + 1, 2);

            return s;
        }
    }
}