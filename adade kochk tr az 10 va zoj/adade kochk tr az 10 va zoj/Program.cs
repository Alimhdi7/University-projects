using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number < 10 && number % 2 == 0)
            {
                Console.WriteLine("True!");
            }
        }
        else
        {
            Console.WriteLine("Invalid entry,please enter integer number");
        }
    }
}