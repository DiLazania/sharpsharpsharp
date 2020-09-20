using System;

namespace Task1{
    class Program{
        static void Main(string[] args){

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
        }

        static void Search(int from, int to){

            int[] replay = new int[to - from + 1];
            int kol = 0;

            while(true){


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
