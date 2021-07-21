using System;

namespace Largest_Among_Three_Numbers
{
   public class Program
   {
       public static void Main(string[] args)
       {
            int num1 = 50;
            int num2 = 20;
            int num3 = 30;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three = " + num1);
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three = " + num3);
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the greatest among three = " + num2);
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three= " + num3);
            }
       }
   }
}
