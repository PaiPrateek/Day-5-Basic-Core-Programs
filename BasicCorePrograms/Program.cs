
using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckEvenOrOdd();
        }
        public static void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter Any Number to check Whether it is Even or odd ");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("The Entered Number {0} is Even", Number);
            }
            else
            {
                Console.WriteLine("The Entered Number {0} is Odd", Number);
            }
        }
    }
}
