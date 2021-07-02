using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    class Reverse
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a number to be reversed :");
            int num = Convert.ToInt32(Console.ReadLine());
            /*..............................................
             Initialize two variables to carry operation and to store the reversed value
            ...................................................................*/
            int rev = 0 , rem = 0;
            while (num > 0)
            {
                rem = num % 10;//In this step we get last digit of the number 
                rev = rev * 10 + rem ;//here we add the digit to rev variable and this is repeated until input is gretaer than 0
                num = num / 10;
            }
            /*....................................................................
             * The number obtained in the rev variable is the reverse of the input number
             * .........................................................*/
            Console.WriteLine("Reversed Number is : "+rev);
        }
    }
}
