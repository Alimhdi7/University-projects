using System;

public class RecursiveMultiplication
{
    public static int Multiply(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        else if (b > 0)
        {
            return a + Multiply(a, b - 1);
        }
        else
        {
            return -Multiply(a, -b);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Program to calculate the product of two numbers with a recursive function");
        Console.WriteLine("Please enter the first number (a):");

        // خواندن عدد اول
        int a = ReadIntegerFromConsole();

        Console.WriteLine("Please enter the second number (b):");

        // خواندن عدد دوم
        int b = ReadIntegerFromConsole();

        // محاسبه حاصل ضرب
        int result = Multiply(a, b);

        Console.WriteLine($"\nThe product of {a} and {b} is equal to: {result}");
    }

    public static int ReadIntegerFromConsole()
    {
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            try
            {
                number = int.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer:");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number entered is too large or too small. Please enter a valid integer:");
            }
        }
    }
}
