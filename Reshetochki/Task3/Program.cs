using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static SafeClass<int> _intSafe;
        private static SafeClass<double> _dblSafe;
        private static SafeClass<string> _strSafe;
        private static SafeClass<char> _chrSafe;
        private static SafeClass<bool> _blSafe;

        static void Duck()
        {
            Duck duck = new Duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
            duck.random_duck();
        }

        static void ClassObjectsCounter()
        {
            Console.WriteLine("If you want to create objects manually, write '1'.\n" +
                "If you want to creat objects with random from 0 to 1000, write '2'\n" +
                "If you want to know a total number of objects, write '3'.\n" +
                "If you want to exit, write '4'");
            var num = true;
            while (num)
            {
                var selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.Write("How many objects do you want to create?  : ");
                        var objs = int.Parse(Console.ReadLine());
                        for (var i = 0; i < objs; i++)
                        {
                            var NewObject = new Counter();
                        }
                        Console.WriteLine($"{objs} objects have been created. What's next?");
                        break;
                    case "2":
                        var rnd = new Random();
                        var value = rnd.Next(0, 1000);
                        Console.WriteLine($"Random wants to create {value} objects");
                        for (var i = 0; i < value; i++)
                        {
                            var newObject = new Counter();
                        }
                        Console.WriteLine($"{value} objects have been created. What's next?");
                        break;
                    case "3":
                        Console.WriteLine($"Summarily created: {Counter.ObjectsCounter} objects. What's next?");
                        break;
                    case "4":
                        Console.WriteLine("Press Enter to exit");
                        num = false;
                        break;
                    default:
                        Console.WriteLine("Write again");
                        break;
                }
            }
            Console.ReadKey();
        }

        private static void SafeClass()
        {


            do
            {
                Console.WriteLine("Create safe - 1.\n Show var in safe - 2.");
                var ss2 = int.Parse(Console.ReadLine() ?? string.Empty);
                switch (ss2)
                {

                    case 1:
                       Console.WriteLine("1.INT.\n 2.BOOL.\n3.CHAR.\n4.STRING.\n5.DOUBLE");
                       var create = int.Parse(Console.ReadLine() ?? string.Empty);

                       switch (create)
                       {
                           case 1:
                               Console.WriteLine("Random value assigned");
                               _intSafe = new SafeClass<int>(new Random().Next());
                               break;
                           case 2:
                               Console.WriteLine("Enter true or false");
                               _blSafe = new SafeClass<bool>(bool.Parse(Console.ReadLine()));
                               break;
                           case 3:
                               Console.WriteLine("Enter char");
                               _chrSafe = new SafeClass<char>(Console.ReadLine().First(x => x is char));
                               break;
                           case 4:
                               Console.WriteLine("Enter string");
                               _strSafe = new SafeClass<string>(Console.ReadLine());
                               break;
                           case 5:
                               _dblSafe = new SafeClass<double>(new Random().NextDouble());
                               break;

                       }

                       break;
                    case 2:
                       try
                       {
                           Console.WriteLine("CHOOSE OUTPUT:\n\n 1.INT.\n 2.BOOL.\n3.CHAR.\n4.STRING.\n5.DOUBLE");
                           var s1 = int.Parse(Console.ReadLine() ?? string.Empty);
                           switch (s1)
                           {
                               case 1:
                                   Console.WriteLine($"{_intSafe.GetValue()}");

                                   break;
                               case 2:
                                   Console.WriteLine($"{_blSafe.GetValue()}");

                                   break;
                               case 3:
                                   Console.WriteLine($"{_chrSafe.GetValue()}");

                                   break;
                               case 4:
                                   Console.WriteLine($"{_strSafe.GetValue()}");

                                   break;
                               case 5:
                                   Console.WriteLine($"{_dblSafe.GetValue()}");
                                   break;

                           }
                       }
                       catch (NullReferenceException ex)
                       {
                           Console.WriteLine("YOu must create safe before reading it!!!!!!");
                           Console.WriteLine(ex.ToString());

                       }

                       break;
                }

            } while (true);

        }

        static void Main(string[] args)
        {
            int select;
            do
            {
                Console.WriteLine("1. ObjectCounter.\n 2. SafeGenericClass.\n 3.Polymorphism ");
                select = int.Parse(Console.ReadLine() ?? string.Empty);

                switch (select)
                {
                    case 1:
                        ClassObjectsCounter();
                        break;
                    case 2:
                        SafeClass();
                        break;
                    case 3:
                        Duck();
                        break;

                }

            } while (select > 0 && select < 5);
        }
    }
}
