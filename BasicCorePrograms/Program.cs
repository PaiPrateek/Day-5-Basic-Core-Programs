
using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargestAmoungThreeNumber();
        }
        public static void LargestAmoungThreeNumber()
        {
            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("......................");
            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("......................");
            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("......................");

            if (a > b && a > c)
            {
                Console.WriteLine("First Entered Number {0} is Larger among three Number:", a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("Second Entered Number {0} is Larger among three Number:", b);
            }
            else
            {
                Console.WriteLine("Third Entered Number {0} is Larger among three Number:", c);
            }
        }
    }
}
