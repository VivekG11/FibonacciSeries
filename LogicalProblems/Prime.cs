using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    class Prime
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number :");
            /*.................................................
             * Enter a number to find it is a prime or not and initialize a variable to compare result
             * ...................................*/
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = 2; i<= n/2 ; i++)
            {
                if(n % i == 0)
                {
                    sum++;
                }
            }
            /*..................................................................
             * if sum == 0 that means entered number has no factors other than "1" so it is a prime number
             * .......................................................................*/
            if( sum == 0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
