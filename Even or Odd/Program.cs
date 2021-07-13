using System;

namespace Even_or_Odd
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) 
            {
                Console.WriteLine(n + " is an Even Number");
            }
            else
            {
                Console.WriteLine(n + " is an Odd Number");
            }
        }
    }
}
