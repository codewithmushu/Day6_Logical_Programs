using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    public class LogicalPrograms
    {
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter the number of terms:");
            int n = Convert.ToInt32(Console.ReadLine());

            int firstTerm = 0;
            int secondTerm = 1;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(firstTerm + " ");

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.WriteLine();
        }

        public static void PerfectNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            if (sum == number)
                Console.WriteLine("It is a perfect number.");
            else
                Console.WriteLine("It is not a perfect number.");
        }

        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("It is a prime number.");
            else
                Console.WriteLine("It is not a prime number.");
        }

        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine("Reversed number: " + reverse);
        }

    }
}
