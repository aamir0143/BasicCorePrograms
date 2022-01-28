using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.LargestAmongThreeNumbers
{
    public  class LargestNumber
    {
        public static void LargestThreeNumbers()
        {
            Console.Write("\tEnter the First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter the Third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine("\t{0}: is the Largest number", firstNumber);
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                Console.WriteLine("\t{0}: is the Largest number", secondNumber);
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                Console.WriteLine("\t{0}: is the Largest number", thirdNumber);
            else
                Console.WriteLine("\tThe Three numbers are equal");
            Console.WriteLine("========================================================================");
        }
    }
}
