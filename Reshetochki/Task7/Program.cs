using System;
using System.Threading.Tasks;
using Switch_Lib;

namespace Task7
{
    internal class Program
    {
        public static bool isCompleted = false;
        private static void Main()
        {
            var menu = new SwitchLib();
            menu.Switch(EnumerateRainbow, LazyGayInitialization, ThreadCompetition);
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
        public static void ThreadCompetition()
        {
            Parallel.Invoke(() => { OutputNumbers(3); }, () => { OutputNumbers(97); });
        }

        private static void OutputNumbers(object num)
        {

            var outCount = 0;
            for (; isCompleted == false;)
            {
                Console.WriteLine(num);
                outCount++;
                if (outCount != 50) continue;
                isCompleted = true;
                Console.WriteLine($"{Task.CurrentId} with {num} WIN!");
            }

        }
    }
}