
using System;

namespace Task._1
{
    class Program
    {
        public static int factorial(int number)
        {
            int result = 1;
            if (number <= 1)
            {
                return 1;
            }
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int fibonacci(int length)
        {
            int c = 0;
            int a = 0;
            int b = 1;
            if (length == 0)
            {
                return 0;
            } else if (length == 1)
            {
                return 1;
            }
            for (int i = 2; i <= length; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для нахождения факториала: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result_of_factorial = factorial(number);
            Console.WriteLine(number.ToString() + "! = " + result_of_factorial.ToString());

            Console.WriteLine("Введите, как долго вы хотите отображать ряд Фибоначчи: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}", fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
