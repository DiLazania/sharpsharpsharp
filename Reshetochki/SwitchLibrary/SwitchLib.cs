using System;
using System.Reflection;

namespace Switch_Lib
{
    public class SwitchLib
    {
        public delegate void FunctionDelegat();
        public void Switch(FunctionDelegat function1, FunctionDelegat function2, FunctionDelegat function3)
        {
            Console.WriteLine($"Choose 1: {function1.GetMethodInfo().Name} \n" +
                              $"       2: {function2.GetMethodInfo().Name} \n" +
                              $"       3: {function3.GetMethodInfo().Name}");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    function1();
                    break;
                case 2:
                    function2();
                    break;
                case 3:
                    function3();
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
        }
    }
}
