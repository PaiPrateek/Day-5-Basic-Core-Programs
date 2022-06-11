using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputeQuotientAndReminder();
        }
        public static void ComputeQuotientAndReminder()
        {
            Console.WriteLine("Enter a Dividend:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("........................");
            Console.WriteLine("Enter a Divisor:");
            int y = Convert.ToInt32(Console.ReadLine());

            int Quotient = x / y;
            int Reminder = x % y;

            Console.WriteLine("The Quotient is :{0}", Quotient);
            Console.WriteLine("The Reminder is : {0}", Reminder);
        }

    }
}
