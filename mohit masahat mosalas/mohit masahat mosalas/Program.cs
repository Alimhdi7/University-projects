using System;

namespace Function
{
    class Program
    {
        // متد محاسبه محیط مثلث
        public static double MohitMosalas(double a, double b, double c)
        {
            return a + b + c;
        }

        // متد محاسبه مساحت مثلث با فرمول هرون
        public static double MasahatMosalas(double a, double b, double c)
        {
            // محاسبه نیم‌محیط
            double s = (a + b + c) / 2;

            // فرمول هرون: Area = sqrt(s * (s - a) * (s - b) * (s - c))
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to calculate the perimeter and area of ​​a triangle");
            Console.WriteLine("--------------------------------");

            // دریافت ورودی برای سه ضلع
            Console.Write("Enter the length of the first side (a): ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side (b).: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side (c): ");
            double sideC = double.Parse(Console.ReadLine());

            // محاسبه و نمایش نتایج
            double perimeter = MohitMosalas(sideA, sideB, sideC);
            Console.WriteLine($"\nPerimeter of a triangle: {perimeter}");

            double area = MasahatMosalas(sideA, sideB, sideC);
            Console.WriteLine($"Area of ​​a triangle: {area}");

            Console.ReadKey();
        }
    }
}
