using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.EvenOrOdd
{
    public class Check
    {
        public static void EvenOrOdd()
        {

            Console.Write("\tEnter the number to Check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("\t{0} is an Even number", num);
            }
            else
            {
                Console.WriteLine("\t{0} is an Odd number", num);
            }
            Console.WriteLine("===========================================================================");
        }
    }
}
