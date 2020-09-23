using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class ReverseStringSentence
    {
        // ex.: "The dog ran." should be "ehT god .nar" - ideally fix punctuation to be at end
        // Need to iterate over whole sentence (string)
        // Extract each word from sentence (split? put in array)
        // Then could iterate over array of words 
        // get each word (element) and reverse it - could use a StringBuilder 
        // could make logic to reverse each word into separate method (reverseString)
        // append each reversed word to a StringBuilder object and return as a string
        // ?? How to handle to punctuation?

        public static string ReverseSentence(string sentence)
        {
            string[] words = sentence.Split(" ");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string reverseWord = ReverseWord(words[i]);
                //char[] charArray = words[i].ToCharArray();
                //Array.Reverse(charArray);
                //sb.Append(charArray).Append(" ");
                sb.Append(reverseWord).Append(" ");
            }


            return sb.ToString();
        }

        public static string ReverseWord(string word)
        {
            String reverseWord = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            return reverseWord;
        }

        // Gordon's solution: 
        // Array.Reverse() over whole charArray will literally reverse the sentence ("The dog ran" would be "ran dog The")
        public static string ReverseSentence2(string str)
        {
            string[] sentenceWords = str.Split(' ');
            Array.Reverse(sentenceWords);
            string newSentence = string.Join(" ", sentenceWords);
            return newSentence;
        }

    }
}
