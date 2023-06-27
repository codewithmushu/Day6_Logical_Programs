using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Fibonacci Series");
                Console.WriteLine("2. Perfect Number");
                Console.WriteLine("3. Prime Number");
                Console.WriteLine("4. Reverse Number");
                Console.WriteLine("5. Coupon Numbers");
                Console.WriteLine("6. Stop Watch");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Write your choice here : ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LogicalPrograms.FibonacciSeries();
                        break;
                    case 2:
                        LogicalPrograms.PerfectNumber();
                        break;
                    case 3:
                        LogicalPrograms.PrimeNumber();
                        break;
                    case 4:
                        LogicalPrograms.ReverseNumber();
                        break;
                    case 5:
                        LogicalPrograms.CouponNumbers();
                        break;
                    case 6:
                        LogicalPrograms.StopwatchProgram();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);
        }
        
    }
}
