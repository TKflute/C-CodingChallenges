using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    // find number of instances of a full word/sequence in a string
    //i.e. Testing Input Strings w/ (5) Permutations:
    //string s2 = "microsoft";
    //string l2 = "uyiicortsmofoocmsfrtitfcdaqfoctmsirouytpotufcrfscmtioooiturefsimrtcoo";

    class FindPermutations
    {
        // can count chars more easily by finding first index in inputString, then last index
        // count of char would be diff btwn two plus 1
        public static int FindPermutations1(string sequence, string inputString)
        {
            // O(n) comparisons, but if sort both strings, can cut back in average cases
            // loop and char array(s)
            // sort both strings so as to avoid double loops (hopefully) and also to cut down on # of comparisons
            // make both strings into char arrays and use Array.Sort()
            // count each instance of a sequence letter in the inputString
            // after counting them all, will need to do some kind of calculation to determine how many full sequences I can build

            char[] sequenceArray = sequence.ToCharArray();
            Array.Sort(sequenceArray);
          
            int[] patternOfChars = FindPattern(sequenceArray); // this would be off, if checking with sorted sequence- in main loop
            // should sort first before finding pattern


            char[] inputArray = inputString.ToCharArray();
            Array.Sort(inputArray);
            // we already have int pattern marking num of each char; now can remove dups for main comparison loop
            sequenceArray = RemoveDuplicateChars(sequenceArray);

            // vars we need to keep track
            int charMatch = 0;
            int fullMatch = 0;
            int[] fullMatchPattern = new int[patternOfChars.Length];
            int index = 0;

            int firstIndex = inputArray.ToString().IndexOf(sequenceArray[0]);
            // NO MATCH OF FIRST CHAR, SO NO MATCHES OF SEQUENCE
            if(firstIndex == -1)
            {
                return -1;
            }
            else
            {
                charMatch = 1;
            }

            for (int i = firstIndex + 1; i < inputArray.Length; i++)
            {
                if(inputArray[i] == sequenceArray[index])
                {
                    charMatch++;
                }
                else
                {
                    fullMatch = charMatch / patternOfChars[index];
                    if(fullMatch == 0)
                    {
                        // NO FULL MATCHES - NO SEQUENCE MATCH
                        return -1;
                    }
                    fullMatchPattern[index] = fullMatch;
                    index++;
                    // HAVE GONE THROUGH WHOLE SEQUENCE ARRAY
                    if(index >= sequenceArray.Length)
                    {
                        break;
                    }
                    // bump i up to first index of next unique char (so skipping and saving iterations)
                    i = inputArray.ToString().IndexOf(sequenceArray[index]);
                    if(i == -1)
                    {
                        return -1;
                    }
                    charMatch = 1;
                }
            }

            // After find all full matches for all chars (no 0's), can find # of full matches for whole word
            // This would be lowest number in fullMatchPattern[] that isn't 0 (in case there were empty slots)
            Array.Sort(fullMatchPattern);
            for(int i = 0; i < fullMatchPattern.Length; i++)
            {   
                if(fullMatchPattern[i] == 0)
                {
                    continue;
                }
              
                return fullMatchPattern[i];
               
            }
            return -1;

        }

        public static char[] RemoveDuplicateChars(char[] sequenceArray)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < sequenceArray.Length; i++)
            {
                if(sequenceArray[i] == sequenceArray[i - 1])
                {
                    continue;
                }
                else
                {
                    sb.Append(sequenceArray[i - 1]);
                }

            }
            return sb.ToString().ToCharArray();
        } 

        public static int[] FindPattern(char[] sortedSequence)
        {
            // make array of ints to store count of each unique letter in sequence
            int[] patternOfChars = new int[sortedSequence.Length];
            int count = 1;
            int index = 0;
            for (int i = 1; i < sortedSequence.Length; i++)
            {
                if (sortedSequence[i] == sortedSequence[i - 1])
                {
                    count++;
                }
                else
                {
                    patternOfChars[index] = count;
                    index++;
                }
            }
            return patternOfChars;
        }
    }
}
