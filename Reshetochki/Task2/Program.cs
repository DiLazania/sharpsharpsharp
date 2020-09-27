using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Sockets;

namespace Task2
{
    class Program
    {
        private static StackT<int> intStack;
        public static void StackT()
        {
            intStack = new StackT<int>();
            var action = 0;
            do
            {
                Console.WriteLine("1. Push element to Stack.\n 2.Pop element from Stack.\n 3.Peek top element.\n 4.Print stack.\n 5.Purge stack.");
                action = int.Parse(Console.ReadLine() ?? string.Empty);
                
                switch (action)
                {
                    case 1:
                        Console.WriteLine("Number to push");
                        intStack.Push(int.Parse(Console.ReadLine() ?? string.Empty));
                        break;
                    case 2:
                        Console.WriteLine(!intStack.IsEmpty()
                            ? $"Popped Element value = {intStack.Pop()}"
                            : "Stack is not created!");
                        break;
                    case 3:
                        Console.WriteLine($"Peeked element: {intStack.Peek()}");
                        break;
                    case 4:
                        if(!intStack.IsEmpty()) intStack.PrintStack();
                        else break;
                        break;
                    case 5:
                        if (!intStack.IsEmpty()) intStack.PurgeStack();
                        else Console.WriteLine($"Stack is clear.");
                        break;
                }
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            } while (action > 0 && action < 6);
        }
       

        static void Main(string[] args)
        {
            int select;
            do
            {
                Console.WriteLine("1. Stack.\n 2. Memes.\n 3.Tournament ");
                select = int.Parse(Console.ReadLine() ?? string.Empty);
                
                switch (select)
                {
                    case 1:
                        StackT();
                        break;
                    case 2:
                        //TODO: Jokes
                        break;
                    case 3:
                        //TODO Tournament Table
                        break;
                    
                }

            } while (select> 0 && select < 5);

        }
    }
}
