using System;
using Switch_Lib;

namespace Task7
{
    internal class Program
    {
        private static void Main()
        {
            var menu = new SwitchLib();
            menu.Switch(EnumerateRainbow, LazyGayInitialization);
        }


        public static void EnumerateRainbow()
        {
            foreach (var color in Enum.GetValues(typeof(Rainbow.RainbowColors)))
                Console.WriteLine(Enum.GetName(typeof(Rainbow.RainbowColors), color));
        }

        public static void LazyGayInitialization()
        {
            while (true)
            {
                Console.Write("Enter country, or 1 to exit:");
                var country = Console.ReadLine();
                if (country == "1") break;
                _ = new RainbowCountry(country);
            }
        }
    }
}