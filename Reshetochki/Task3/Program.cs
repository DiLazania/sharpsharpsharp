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
                                _chrSafe = new SafeClass<char>(Console.ReadLine().First(x=>x is char));
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

            var s2 = int.Parse(Console.ReadLine() ?? string.Empty);
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
                        //TODO ObjectCounter
                        break;
                    case 2:
                        SafeClass();
                        break;
                    case 3:
                        //TODO Polymorphism
                        break;

                }

            } while (select > 0 && select < 5);
        }
    }
}
