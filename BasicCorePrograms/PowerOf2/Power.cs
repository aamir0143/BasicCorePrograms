using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.PowerOf2
{
    public class Power
    {
        public static void PowerOfTwo()
        {
            Console.Write("\tEnter the Power Value: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= exponent; i++)
            {
                Console.WriteLine("\t2^{0} " + " " + "= {1}", i, Math.Pow(2, i));
            }
            Console.WriteLine("==================================================================");
        }
    }
}
