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
    }
}
