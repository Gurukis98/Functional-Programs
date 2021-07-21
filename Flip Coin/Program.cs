using System;

namespace Flip_Coin
{
   public class Program
   {
       public static void Main(string[] args)
       {
            int count = 0;
            int tails = 0;
            int heads = 0;


            while (count < 5)
            {
                Random random = new Random();
                int coin = random.Next(0, 2);
                if (coin == 1)
                {
                    Console.WriteLine("Tails");
                    tails = tails + 1;
                    count = count + 1;
                   
                }
                else if (coin == 0)
                {
                    Console.WriteLine("Heads.");
                    heads = heads + 1;
                    count = count + 1;
                }
               
                Console.WriteLine("Heads = " + heads);
                Console.WriteLine("Tails = " + tails);
                int percentage_for_heads = (int)Math.Round((double)(100 * heads) / 100 * 10);
                int percentage_for_tails = (int)Math.Round((double)(100 * tails) / 100 * 10);
                Console.WriteLine("Heads Percentage=" + percentage_for_heads);
                Console.WriteLine("Tails Percentage=" + percentage_for_tails);

            }
       }
   }
}
