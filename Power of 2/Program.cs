using System;

namespace Power_of_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = Math.Pow(2, 10);

            Console.WriteLine("Enter a year = " + x);

            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
            {
                Console.WriteLine("Leap Year = " + x);
            }
            else
            {
                Console.WriteLine("Not a Leap Year. = " + x);
            }
        }
    }
}
    

