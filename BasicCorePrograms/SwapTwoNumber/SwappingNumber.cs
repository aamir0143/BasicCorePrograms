using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.SwapTwoNumber
{
    public class SwappingNumber
    {
        public static void SwapTwoNumber()
        {
            Console.Write("\tEnter the First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("\tAfter Swapping these Two Numbers are:\n\tFirst number is: " + firstNumber + "\n\tAnd Second number is: " + secondNumber);
            Console.WriteLine("=============================================================================================");
        }
    }
}
