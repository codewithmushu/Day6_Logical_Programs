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

        public static void CouponNumbers()
        {
            Console.WriteLine("Enter the number of distinct coupon numbers:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] coupons = new int[n];
            Random random = new Random();

            int count = 0;
            int distinctCount = 0;

            while (distinctCount < n)
            {
                int randomNumber = random.Next(1, n + 1);

                count++;

                if (!coupons.Contains(randomNumber))
                {
                    coupons[distinctCount] = randomNumber;
                    distinctCount++;
                }

            }
            Console.WriteLine("Total random numbers needed: " + count);
        }

        public static void StopwatchProgram()
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch...");
            Console.ReadKey();

            DateTime stopTime = DateTime.Now;

            TimeSpan elapsedTime = stopTime - startTime;

            Console.WriteLine("Elapsed time: " + elapsedTime.TotalSeconds + " seconds");
        }

    }
}
