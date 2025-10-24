using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 7 == 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                int result = number * 3;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Invalid entry,please enter integer number");
        }
    }
}