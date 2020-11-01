using System;
using System.Drawing;
using Switch_Lib;
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var menu = new SwitchLib();
            menu.Switch(EnumerateRainbow);
        }


        public static void EnumerateRainbow()
        {
            var textColor = System.ConsoleColor.Red;
            foreach (var color in Enum.GetValues(typeof(Rainbow.RainbowColors)))
            {
                Console.WriteLine(Enum.GetName(typeof(Rainbow.RainbowColors), color));
                Console.ForegroundColor = textColor++;
            }
        }
    }
}
