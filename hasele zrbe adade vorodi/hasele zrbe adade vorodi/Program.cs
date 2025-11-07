using System;

public class Program
{
    public static void Main(string[] args)
    {
        long product = 1;

        while (true)
        {
            Console.Write("Enter a number,(to end enter 0) ");

            try
            {
                int number = Int32.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                product *= number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error The input is invalid. Please enter a number:");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error The entered number is outside the allowed range");
            }
        }

        Console.WriteLine($"\nThe final product of the entered numbers:{product}");
    }
}
