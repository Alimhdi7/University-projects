using System;

public class DayOfWeek
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number between 1 to 7");

        string input = Console.ReadLine();

        try
        {
            int dayNumber = Int32.Parse(input);

            string dayName;

            // Use a switch statement to determine the day of the week
            switch (dayNumber)
            {
                case 1:
                    dayName = "Shanbe";
                    break;
                case 2:
                    dayName = "1shanbe";
                    break;
                case 3:
                    dayName = "2shanbe";
                    break;
                case 4:
                    dayName = "3shanbe";
                    break;
                case 5:
                    dayName = "4shanbe";
                    break;
                case 6:
                    dayName = "5shanbe";
                    break;
                case 7:
                    dayName = "Jome";
                    break;
                default:
                    dayName = "!END";
                    break;
            }

            Console.WriteLine(dayName);
        }
        catch (FormatException)
        {
            Console.WriteLine("!END");
        }
        catch (OverflowException)
        {
            Console.WriteLine("!END");
        }
    }
}