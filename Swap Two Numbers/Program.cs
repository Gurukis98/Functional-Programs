using System;

namespace Swap_Two_Numbers
{
   public class Program
   {
      public static void Main(string[] args)
      {
            int a = 5, b = 10;
            Console.WriteLine("Before Swap a = " + a + " b= " + b);
            a = a * b;   
            b = a / b;       
            a = a / b;     
            Console.Write("After Swap a = " + a + " b= " + b);
      }
   }
}
