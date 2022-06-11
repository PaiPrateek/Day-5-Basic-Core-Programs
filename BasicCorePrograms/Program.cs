using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckHarmonicNumber();
        }
        public static void CheckHarmonicNumber()
        {
            double Result = 0.0;
            Console.WriteLine("Enter any Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {

                Console.Write("1/{0} + ", i);
                Result += 1 / (double)i;

            }
            Console.WriteLine("Sum of Harmonic Number Series up to {0} is :{1} ", Number, Result);
        }

    }
}
