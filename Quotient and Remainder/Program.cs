using System;

namespace Quotient_and_Remainder
{
   public class Program
   {
       public static void Main(string[] args)
       {
            int divident = 64;
            int divisor = 8;
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Quotient= " + quotient);
            Console.WriteLine("Remainder= " + remainder);
       }
   }
}
