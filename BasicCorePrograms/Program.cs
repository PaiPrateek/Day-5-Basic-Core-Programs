using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckLeapYear();
        }
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter A Year ");
            int Year=Convert.ToInt32(Console.ReadLine());
            if (Year%4==0 & (Year%100!=0 || Year%400==0))
            {
                Console.WriteLine("Entered Year {0} is a Leap Year", Year);
            }
            else
            {
                Console.WriteLine("Entered Year {0} is not a Leap Year", Year);
            }
        }


    }
}
