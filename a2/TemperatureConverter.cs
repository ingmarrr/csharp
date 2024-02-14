
using System.Security.Cryptography;

namespace Apps
{

    public static class TemperatureConverter
    {
        public static void Start()
        {
            Cli.WriteTitle("Temperature Converter");

            var menuItems = new Cli.Item[]
            {
                new(1, "Celsius to Fahrenheit"),
                new(2, "Fahrenheit to Celsius"),
                new(0, "Exit")
            };


            for (var ok = true; ok;)
            {
                ok = Cli.AskChoice(menuItems) switch
                {
                    0 => false,
                    1 => CelsiusToFahrenheit(),
                    2 => FahrenheitToCelsius(),
                    _ => true
                };
            }
        }

        private static bool CelsiusToFahrenheit()
        {
            var i = 0;
            for (var c = 0; c <= 100; c += 5)
            {
                var f = c * 9 / 5 + 32;
                Console.Write("{0, 8:0.00} C = {1, 8:0.00} F", c, f);
                Console.Write(++i % 3 == 0 ? "\n" : "\t\t");
            }

            return true;
        }

        private static bool FahrenheitToCelsius()
        {
            var i = 0;
            for (var f = 0; f <= 212; f += 10)
            {
                var c = (f - 32) * 5 / 9;
                Console.Write("{0, 8:0.00} F = {1, 6:0.00} C\t", f, c);
                Console.Write(++i % 2 == 0 ? "\n" : "\t\t");
            }

            return true;
        }

    }
}