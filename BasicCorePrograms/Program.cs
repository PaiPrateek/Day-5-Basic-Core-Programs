using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwapTwoNumber();
        }
        public static void SwapTwoNumber()
        {
            int temp = 0;
            Console.WriteLine("Enter First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("......................");
            Console.WriteLine("Enter Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("......................");
            Console.WriteLine("Before Swaping Two Number First Number is :{0} and Second Number is : {1}", X, Y);

            X = Y;
            Y = temp;
            temp = Y;
            Console.WriteLine("After Swaping Two Number FirstNumber is :{0} and Second Number is : {1}", X, temp);

        }

    }
}
