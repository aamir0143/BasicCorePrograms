// See https://aka.ms/new-console-template for more information
using BasicCorePrograms.EvenOrOdd;
using BasicCorePrograms.FlipCoin;
using BasicCorePrograms.HarmonicNumber;
using BasicCorePrograms.LeapYear;
using BasicCorePrograms.PowerOf2;
using BasicCorePrograms.PrimeFactors;
using BasicCorePrograms.QuotientAndRemainder;
using BasicCorePrograms.SwapTwoNumber;
using BasicCorePrograms.VowelOrConstant;
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
                    Console.WriteLine("\t2. Leap Year");
                    Console.WriteLine("\t3. Power Of Two");
                    Console.WriteLine("\t4. Harmonic Number");
                    Console.WriteLine("\t5. Factors");
                    Console.WriteLine("\t6. QuotientAndRemainder");
                    Console.WriteLine("\t7. Swap Two Numbers");
                    Console.WriteLine("\t8. Check Even Or Odd");
                    Console.WriteLine("\t9. Check For Vowel Or Consonant");
                    Console.WriteLine("\t10. Exit");
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Flip Coin==========");
                            FlipCoin.CheckPercentage();//Call the method
                            break;
                        case 2:
                            Console.WriteLine("\n\t========== 2. Leap Year==========");
                            Year.LeapYear();
                            break;
                        case 3:
                            Console.WriteLine("\n\t========== 3. Power Of Two==========");
                            Power.PowerOfTwo();
                            break;
                        case 4:
                            Console.WriteLine("\n\t========== 4. Harmonic Number==========");
                            Harmonic.HarmonicNumber();
                            break;
                        case 5:
                            Console.WriteLine("\n\t========== 5. Factors==================");
                            Factor.PrimeFactor();
                            break;
                        case 6:
                            Console.WriteLine("\n\t========== 6. QuotientAndRemainder======");
                            QuotientRemainder.QuotientAndRemainder();
                            break;
                        case 7:
                            Console.WriteLine("\n\t========== 7. Swapping Two Numbers========");
                            SwappingNumber.SwapTwoNumber();
                            break;
                        case 8:
                            Console.WriteLine("\n\t========== 8. Check Even Or Odd============");
                            Check.EvenOrOdd();
                            break;
                        case 9:
                            Console.WriteLine("\n\t========== 9. Check for Vowel Or Consonant====");
                            Alphabet.CheckVowelOrConsonant();
                            break;
                        case 10:
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

