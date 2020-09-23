using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class FizzBuzz
    {
        public static void FizzBuzz1(int n)
        {
            // loop through sequence leading up to n
            // if n % 3 == 0, print "Fizz"
            // if n % 5 == 0, print "Buzz"
            // if n% 3 == 0 && n % 5 == 0, print "FizzBuzz"

            for(int i = 3; i <= n; i++)
            {
                if(n % 5 == 0 && n % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
