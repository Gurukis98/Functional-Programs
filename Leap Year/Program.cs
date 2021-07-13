using System;

namespace Leap_Year
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 2021;

            Console.WriteLine("Enter a year = " + x);

            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
            {
                Console.WriteLine("Leap Year = " + x);
            }
            else
            {
                Console.WriteLine("Not a Leap Year = " + x);
            }
        }
    }
}

