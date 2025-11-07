using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Letter I:");
        DrawI();
        Console.WriteLine("\n--------------------\n");

        Console.WriteLine("Letter H:");
        DrawH();
        Console.WriteLine("\n--------------------\n");

        Console.WriteLine("Letter E:");
        DrawE();
    }

    // تابع برای رسم حرف I (اندازه 7x5)
    public static void DrawI()
    {
        // خطوط بالا و پایین
        string topBottom = "*****";
        // خطوط میانی
        string middle = "  *  ";

        Console.WriteLine(topBottom);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(middle);
        }
        Console.WriteLine(topBottom);
    }

    // تابع برای رسم حرف H (اندازه 7x5)
    public static void DrawH()
    {
        // خطوط بالا و پایین
        string side = "*   *";
        // خط میانی
        string middle = "*****";

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(side);
        }
        Console.WriteLine(middle);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(side);
        }
    }

    // تابع برای رسم حرف E (اندازه 7x5)
    public static void DrawE()
    {
        // خطوط افقی
        string horizontal = "*****";
        // خطوط عمودی
        string vertical = "*    ";

        Console.WriteLine(horizontal);
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(vertical);
        }
        Console.WriteLine(horizontal);
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(vertical);
        }
        Console.WriteLine(horizontal);
    }
}
