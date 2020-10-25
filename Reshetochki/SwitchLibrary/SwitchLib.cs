using System;
using System.Reflection;

namespace Switch_Lib
{
    public class SwitchLib
    {
        public delegate void FunctionDelegat();
        public void Switch(params FunctionDelegat[] functions)
        {
            var i = 0;
            foreach (var func in functions)
            {
                Console.WriteLine($"Choose function to execute:\n {i++} : {func.GetMethodInfo()?.Name}");
            }
            functions[int.Parse(Console.ReadLine()!)].Invoke();
        }
    }
}
