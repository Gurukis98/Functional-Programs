using System;

namespace Vowel_or_Consonant
{
   public class Program
   {
       public static void Main(string[] args)
       {
            char ch;

            Console.WriteLine("Enter a character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else 
            {
                Console.WriteLine(ch + " is Consonant.");
            }
       }
   }
}
