using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Enter a temperature (Celsius): ");

            celsius = Convert.ToDouble(Console.ReadLine());
            // celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0} °C is {1} °F", celsius, fahrenheit);
        }
    }
}