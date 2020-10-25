using System;
using System.Globalization;
using System.Text;
using Switch_Lib;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new SwitchLib();
            menu.Switch(HitlerTime);
        }

        public static void HitlerTime()
        {
            Console.InputEncoding = Encoding.ASCII;
            var hitlerBirth = new DateTime(1889, 4, 20, 18, 30, 57,324);
            while (true)
            {
                try
                {
                    Console.Write($"Enter date in following format dd%MM^yyyy : ");
                    var input = Console.ReadLine();
                    var targetTime = DateTime.ParseExact(input, @"dd\%MM^yyyy", CultureInfo.InvariantCulture);
                    var difference = DateTime.MinValue + (targetTime - hitlerBirth);
                    Console.WriteLine(
                        $"\nFrom Hitler's birth:\n {difference.Year - 1} Years\n {difference.Month - 1} Months\n" +
                        $" {difference.Day - 1} Days\n {difference.Hour} Hours\n {difference.Minute} Minutes\n {difference.Second} " +
                        $"Seconds\n {difference.Millisecond} Milliseconds\n {difference.Ticks} Ticks.");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
