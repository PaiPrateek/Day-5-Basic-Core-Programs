using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckPrimeFactor();
        }
        public static void CheckPrimeFactor()
        {
            int i, j, Count = 0;
            Console.WriteLine("Enter Any Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Count = 0;
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            Count++;
                    }
                    if (Count == 2)
                    {
                        Console.WriteLine("Prime Factors are " + i);
                    }

                }
            }
        }

    }
}
