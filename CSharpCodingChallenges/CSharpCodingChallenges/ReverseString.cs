using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class ReverseString
    {

        // taking in a string
        // returning the reverse string
        // "Hello, World!" -> "!dlroW , olleH";

        public static string ReverseString1(string input)
        {
            // Array.Reverse() (in Java there is StringBuilder.reverse())
            // convert to array of chars, call Reverse and turn back into a string
            char[] inputArr = input.ToCharArray();
            Array.Reverse(inputArr);
            string reverse = new string(inputArr);
            return reverse;
        }

        public static string ReverseString2(string input)
        {
            // manual version
            // looping through chars backwards, appending to a StringBuilder in loop
            // return SB.toString()

            StringBuilder sb = new StringBuilder();
            char[] inputArr = input.ToCharArray();
            for(int i = inputArr.Length - 1; i >= 0; i--)
            {
                sb.Append(inputArr[i]);
            }

            return sb.ToString();
        }
    }
}
