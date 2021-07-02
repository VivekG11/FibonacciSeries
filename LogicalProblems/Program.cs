using System;

namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems ..........");
            /*...........................................................
             * choose an option to perform particular operation
             * .................................................*/
            Console.WriteLine("Enter Your Choice :");
            int options = Convert.ToInt32(Console.ReadLine());
            /*..............................................................
             * Choose options using switch case
             * ................................................*/
            switch (options)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series ......");
                    Fibonacci.FindFibonacciSeries();
                    break;
                case 2:
                    Console.WriteLine("Finding a Perfect Number ........");
                    PerfectNumber.FindPerfectNumber();
                    break;
                default:
                    break;
            }
        }
    }
}
