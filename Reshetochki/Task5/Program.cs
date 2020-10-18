using System;
using Switch_Lib;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchLib.FunctionDelegat function1, function2, function3;
            function1 = Library;
            function2 = Task2; //!!! <- delete comment after corecting
            function3 = Task3; //!!! <- delete comment after corecting
            SwitchLib f = new SwitchLib();
            f.Switch(function1, function2, function3);
            Console.ReadKey();
        }
        public static void Library()
        {
            Console.WriteLine("I just creat a library");
        }

        public static void Task2() //!!! <- delete comment after corecting
        {

        }
        public static void Task3() //!!! <- delete comment after corecting
        {

        }
    }
}
