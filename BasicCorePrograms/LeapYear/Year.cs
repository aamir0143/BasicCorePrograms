using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.LeapYear
{
    class Year
    {
        public static void LeapYear()  
        {
            Console.Write("\tEnter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("\t{0} is a leap year ", year);
            }
            else
            {
                Console.WriteLine("\t{0} is not a leap year ", year);
            }
            Console.WriteLine("========================================================================");
        }
    }
}
