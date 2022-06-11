
using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckVowelOrConsonant();
        }
        public static void CheckVowelOrConsonant()
        {
            char alpha;
            Console.WriteLine("Enter any Alphabet to check whether it is Vowel or Consonant");
            char Alph = Convert.ToChar(Console.ReadLine());
            alpha = char.ToLower(Alph);
            if ((alpha == 'a') || (alpha == 'e') || (alpha == 'i') || (alpha == 'o') || (alpha == 'u'))
            {
                Console.WriteLine("Entered Alphabet {0} is Vowel", Alph);
            }
            else
            {
                Console.WriteLine("Entered Alphabet {0} is Consonant", Alph);
            }
        }
    }
}
