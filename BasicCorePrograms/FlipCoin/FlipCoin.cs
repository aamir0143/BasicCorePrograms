using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.FlipCoin
{
    public class FlipCoin
    {
        public static void CheckPercentage()
        {
            Console.Write("\tEnter the number of times to flip coin: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double flip = random.Next(0, 2);
                if (flip < 0.5)
                {
                    Console.WriteLine("\tTails");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("\tHeads");
                    headCount++;
                }
            }
            headCount *= (100 / num);
            tailCount *= (100 / num);
            Console.WriteLine("\tThe Percentage of Heads is: {0}% " , headCount);
            Console.WriteLine("\tThe Percentage of Tails is: {0}% " , tailCount);
            Console.WriteLine("==================================================================");
            Console.ReadKey();

        }
    }
}
