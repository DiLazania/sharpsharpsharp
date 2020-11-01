using System;
using System.Collections.Generic;

namespace Task7
{
    internal class RainbowCountry
    {
        public List<Rainbow> FiveRainbows => _rainbowsLazy.Value;

        private readonly Lazy<List<Rainbow>> _rainbowsLazy = new Lazy<List<Rainbow>>(() => new List<Rainbow>
        {
            new Rainbow(),
            new Rainbow(),
            new Rainbow(),
            new Rainbow(),
            new Rainbow(),
        });

        public RainbowCountry(string countryName)
        {
            switch (countryName)
            {
                case "Russia":
                    var colors = new[]
                    {
                        ConsoleColor.Red,
                        ConsoleColor.DarkYellow,
                        ConsoleColor.Yellow,
                        ConsoleColor.Green,
                        ConsoleColor.Cyan,
                        ConsoleColor.Blue,
                        ConsoleColor.DarkMagenta
                    };

                    var ptr = 0;
                    Console.WriteLine("There is your 5 rainbows:");
                    foreach (var unused in FiveRainbows)
                    {
                        foreach (var rainbowColor in Enum.GetValues(typeof(Rainbow.RainbowColors)))
                        {
                            Console.ForegroundColor = colors[ptr++];
                            Console.WriteLine(Enum.GetName(typeof(Rainbow.RainbowColors), rainbowColor));
                        }

                        ptr = 0;
                        Console.WriteLine("\n------------------------------\n");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("No rainbows this time, try another country :(");
                    break;
            }

            
        }
    }
}