using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: Reverse Linked List
            //string[] words = { "red", "orange", "yellow", "green", "blue", "purple" };
            //LinkedList<string> linkedList = new LinkedList<string>(words);
            //LinkedList<string> reverseList = ReverseLinkedList.ReverseLinkedList5(linkedList);
            //LinkedListNode<string> node = reverseList.First;
            //while (node.Next != null)
            //{
            //    Console.WriteLine(node.Value);
            //    // check that pointer is correct
            //    Console.WriteLine(node.Next.Value);
            //    node = node.Next;
            //}

            // Challenge 2: Reverse a sentence while maintaining order of words
            //string sentence = "The dog ran.";
            //string reverseSentence = ReverseStringSentence.ReverseSentence2(sentence);
            //Console.WriteLine(reverseSentence);

            // Binary Search Review
            //int[] arr = { 2, 4, 6, 8, 10 };
            //int target = 8;
            //int index = BinarySearchExample.BinarySearchRecursive(target, arr, 0, arr.Length - 1);
            //Console.WriteLine("Index of target should be 3: " + index);

            //string input = "Hello, World!";
            //string reverseString = ReverseString.ReverseString1(input);
            //Console.WriteLine(reverseString);

            //int num = 56789;
            //int reverseNum = ReverseInteger.ReverseInteger1(num);
            //Console.WriteLine(reverseNum);
            //Console.WriteLine(9 % 10);
            //Console.WriteLine(9 / 10);
            //Console.WriteLine(Int32.MaxValue);

            //int max = Int32.MaxValue;
            //int shouldThrow = ReverseInteger.ReverseInteger1(max);
            //Console.WriteLine(shouldThrow);

            // Practicing w/ Collections
            //CollectionsPractice.MessingWithCollections();

            //Remove duplicates from LinkedList
            string[] words = { "red", "orange", "orange", "yellow", "yellow", "green", "blue", "purple" };
            LinkedList<string> linkedList = new LinkedList<string>(words);
            foreach (string value in linkedList)
            {
                Console.WriteLine(value);
            }
            linkedList = RemoveDuplicatesFromLinkedList.RemoveDuplicateNodes(linkedList);
            foreach (string value in linkedList)
            {
                Console.WriteLine(value);
            }

            // Find middle node one pass- 2 versions, with or without using Count
            //LinkedListNode<string> middleNode = FindMiddleNodeOfLinkedList.FindMiddleNodeNoCount(linkedList);
            //// should be 'green' for an even numbered LL
            //Console.WriteLine(middleNode.Value);
            //linkedList.RemoveLast();
            //// should be 'yellow' for odd numbered LL
            //middleNode = FindMiddleNodeOfLinkedList.FindMiddleNodeNoCount(linkedList);
            //Console.WriteLine(middleNode.Value);

            //string[] array = { "red", "orange", "yellow", "green", "blue" };
            //LinkedList<string> linkedList = new LinkedList<string>(array);
            //foreach(string value in linkedList)
            //{
            //    Console.WriteLine(value);
            //}
            //// this should remove 'yellow'
            //FindNthNode.RemoveNthNodeFromLastSinglyLinked(linkedList, 3);
            //foreach (string value in linkedList)
            //{
            //    Console.WriteLine(value);
            //}
        }
    } 
}
