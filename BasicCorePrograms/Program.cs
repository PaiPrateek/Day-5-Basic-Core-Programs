using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckFlipCoin();
        }
        public static void CheckFlipCoin()
        {
            double TailCount=0, HeadCount=0;
            double TailPercentage=0, HeadPercentage=0;

            Console.WriteLine("Enter the Number of Times Coin shall be Flip");
            int Flip = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i < Flip;i++)
            {
                Random random = new Random();
                int Result = random.Next(0,2);

                if(Result == 0)
                {
                    Console.WriteLine("It is Tail");
                    TailCount++;
                }
                else
                {
                    Console.WriteLine("It is Head");
                    HeadCount++;
                }

            }
            TailPercentage = ( TailCount / Flip) * 100;
            HeadPercentage = ( HeadCount / Flip) * 100;
            Console.WriteLine("Total Head Percentage is :" + HeadPercentage);
            Console.WriteLine("Total Tail Percentage is :" + TailPercentage);
        }
    }
}
