using System;

public class Program
{
    public static void Main(string[] args)
    {
        const int requiredInputs = 5;
        int positionOfTwo = -1; // -1 به معنای پیدا نشدن است

        Console.WriteLine($"Enter a integer number{requiredInputs}:");

        for (int i = 0; i < requiredInputs; i++)
        {
            Console.Write($"number {i + 1}: ");
            string input = Console.ReadLine();

            try
            {
                int number = Int32.Parse(input);

                if (number == 2 && positionOfTwo == -1)
                {
                    positionOfTwo = i + 1; // موقعیت ۱-مبنا (اولین عدد، دومین عدد و...)
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The entered number is too large or small.");
            }
        }

        Console.WriteLine("\n--- result ---");

        if (positionOfTwo != -1)
        {
            Console.WriteLine($"Yes, the number 2 is in the inputs. This number is the {positionOfTwo}th number entered.");
        }
        else
        {
            Console.WriteLine("No, the number 2 is not among the 5 numbers entered.");
        }
    }
}
