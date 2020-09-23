using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class ReverseInteger
    {
        public static int ReverseInteger1(int num)
        {
            // 12345 => 54321
            // 1 way using Array.Reverse - convert num to a string, then to char array 
            // then call Array.Reverse, back to string, back to number

            // 2nd way using only numbers/math: num % 10 to get each digit
            // do integer division to get rest of digits
            // how to concantenate digits?: 
            // current value * 10 + next digit
            // this way might be more robust b/c of possible conversion/parsing errors
            // KEY: reversing a very large int may put it out of bounds for ints!!!
            long reverseNum = 0;
            while (num != 0)
            {
                //int currentDigit = num % 10;
                reverseNum = (reverseNum * 10) + (num % 10);
                num /= 10;
            }

            if(reverseNum > Int32.MaxValue || reverseNum < Int32.MinValue)
            {
                throw new Exception("Reverse value of input is out of bounds for an integer");
            }
            
            return (int)reverseNum;
        }
    }
}
