// See https://aka.ms/new-console-template for more information
using BasicCorePrograms.FlipCoin;
using System;
namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Welcome To Basic Core Programs =================");
            Console.WriteLine();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Choose any one option");
                    Console.WriteLine("\t1. Flip Coin");
                    Console.WriteLine("\t2. Exit");
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Flip Coin==========");
                            FlipCoin.CheckPercentage();//Call the method
                            break;
                        case 2:
                        default:
                            flag = false;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error message");
                    flag = false;
                    
                }
            }
        }
    }
}

