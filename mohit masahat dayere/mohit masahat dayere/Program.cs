using System;

namespace Mohit
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, mohit, masahat;
            const double PI = 3.141592653589793;

            Console.Write("Enter radius: ");
            a = double.Parse(Console.ReadLine());

            mohit = 2 * PI * a;        // محیط = 2πr
            masahat = PI * a * a;      // مساحت = πr²

            Console.WriteLine("Masahat is {0} and Mohit is {1}", masahat, mohit);

            Console.ReadKey();
        }
    }
}