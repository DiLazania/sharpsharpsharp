using System;

namespace Task1{
    class Program
    {

        private static int FactorialN(int num)
        {
            var result = 1;
            for (var i = 1; i <= num; i++) result *= i;
            return result;
        }

        private static void FibonacciN(int n)
        {
            var a = 1;
            var b = 1;
            Console.Write($"{n} first fib numbers:  1  1 ");
            for (var i = 0; i < n - 2; i++)
            {
                var c = a + b;
                (a, b) = (b, c);
                Console.Write($" {c} ");
            }
        }

        private static int InputN()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Enter only int numbers!!!");
            return n;
        }

        private static int GuessNumber()
        {
            var rnd = new Random();
            var lowerBound = rnd.Next(1, 15);
            var upperBound = rnd.Next(30, 45);
            Console.WriteLine($"Think about number between {lowerBound} and {upperBound}. When you are ready, press any key to start.");
            Console.ReadKey();
            var gameOver = false;
            var median = (lowerBound + upperBound) / 2;
            var step = 0;
            do
            {
                Console.Write($" Step {step++}. Is the number {median} correct?\n 1 ---- Yes.\n 2 ---- no");
                var select = InputN();
                switch (select)
                {
                    case 1:
                        gameOver = true;
                        break;
                    case 2:
                        Console.WriteLine("Was the number higher or lower than expected??\n 1 ---- Higher.\n 2 ---- Lower ");
                        if (InputN() == 1) upperBound = median - 1;
                        else lowerBound = median + 1;
                        median = (lowerBound + upperBound) / 2;
                        break;
                }
            } while (!gameOver);
            return median;
        }

        static void Main(string[] args)
        {
            int c;
            do
            {
                Console.WriteLine("1. Factorial of N.\n2. Fibonacci sequence first N numbers.\n3. Guess random number.\n4. Exit.");
                c = int.Parse(Console.ReadLine() ?? string.Empty);
                int n;
                switch (c)
                {
                    case 1:
                        Console.Write("Enter N:");
                        n = InputN();
                        Console.WriteLine($"Factorial of {n} = {FactorialN(n)}\n Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter N:");
                        n = InputN();
                        FibonacciN(n);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите диапазон угадываемых чисел");
                        Console.Write("От ");
                        int from = int.Parse(Console.ReadLine());
                        Console.Write("До ");
                        int to = int.Parse(Console.ReadLine());

                        Console.WriteLine("Загадайте целое число от {0} до {1}", from, to);

                        Console.WriteLine("Введите 'старт', чтобы начать");
                        if (Console.ReadLine() == "старт")
                        {
                            Search(from, to);
                            Console.WriteLine("Число угадано");
                        }
                        else Console.WriteLine("Начните заново");

                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (c > 0 && c < 4);
        }
        static void Search(int from, int to)
        {

            int[] replay = new int[to - from + 1];
            int kol = 0;

            while (true)
            {


                Random rnd = new Random();
                int value = rnd.Next(from, to + 1);

                bool f = false;
                for (int i = 0; i < kol; i++)
                {
                    if (replay[i] == value)
                    {
                        f = true;
                        break;
                    }
                }
                if (f == false)
                {
                    replay[kol] = value;
                    kol++;
                    Console.WriteLine("Ваше число {0}?\nВведите 'да'/'нет'", value);
                    if (Console.ReadLine() == "да") break;
                }
            }
        }
    }
}
