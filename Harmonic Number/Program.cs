using System;

namespace Harmonic_Number
{
   public class Program
   {
       public static void Main(string[] args)
       {
            double a;
            double b = 0;
            int n = 5;
            for (a = 1; a <= n; a++)
                b = b + 1 / a;  
            {
                Console.WriteLine(b);
                Console.WriteLine("Harmonic Number = " + b);
            }
       }
   }
}
