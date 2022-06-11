using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckPowerOfTwo();
        }
        public static void CheckPowerOfTwo()
        {
            int Result = 1;
            Console.WriteLine("Enter a Number to Calculate the Power of 2");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number <= 31)
            {
                for (int i = 0; i < Number; i++)
                {
                    Result *= 2;
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Number Less than 31");
            }

            Console.WriteLine("The Power of 2 of the Entered Number is :" + Result);
        }
    }
}
