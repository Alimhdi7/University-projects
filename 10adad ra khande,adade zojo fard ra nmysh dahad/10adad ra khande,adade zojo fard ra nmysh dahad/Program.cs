using System;

public class EvenOddCounter
{
    public static void Main(string[] args)
    {
        int evenCount = 0;
        int oddCount = 0;
        const int totalNumbers = 10;

        Console.WriteLine($"Enter a number{totalNumbers}:");

        for (int i = 0; i < totalNumbers; i++)
        {
            Console.Write($"number {i + 1}: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The input is invalid. Please enter an integer:");
                i--; // Decrement i to re-read the current number
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered is too large or too small. Please enter a number within the allowed range:");
                i--;
            }
        }

        Console.WriteLine("\n--- results ---");
        Console.WriteLine($"Number of even numbers: {evenCount}");
        Console.WriteLine($"Number of odd numbers: {oddCount}");
    }
}
