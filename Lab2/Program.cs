using System;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Task1();
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Task2();
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Task3(); 
        }

        public static void Task1()
        {
            Console.WriteLine("Введите n...");

            int n;
            try
            {
                int minElement = int.MaxValue;
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                    Error();
                else
                {
                    Console.WriteLine("Вводите числа...");
                    for (int i = 0; i < n; i++)
                    {
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num < minElement)
                            minElement = num;
                    }
                    Console.WriteLine($"Минимальный элменет последовательности = {minElement}");
                }
            }
            catch
            {
                Error();
            }
        }

        public static void Task2()
        {
            try
            {

                Console.WriteLine("Вводите числа...");
                int num = 1;
                int countEvenElements = 0;
                while (num != 0)
                {
                    num = Convert.ToInt32(Console.ReadLine());


                    if (num % 2 == 0)
                        countEvenElements++;
                }
                Console.WriteLine($"Количество четных элементов в последовательности = {countEvenElements}");

            }
            catch
            {
                Error();
            }
        }

        static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Task3()
        {
            Console.WriteLine("Введите n...");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                    Error();

                double s = 0;
                double denominator = 3;

                for (int i = 0; i < n; i++)
                {
                    s += 1 / Math.Pow(denominator, 2);
                }

                s += 1 / Math.Pow(2 * n + 1, 2);

                Console.WriteLine($"S = 1/3^2 + 1/5^2 + 1/7^2... + 1/(2n+1)^2 = {s}");
            }
            catch
            {
                Error();
            }
        }
    }
}