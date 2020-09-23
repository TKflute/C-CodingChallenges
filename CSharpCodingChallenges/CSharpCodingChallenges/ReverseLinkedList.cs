using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodingChallenges
{
    class ReverseLinkedList
    {
        public static LinkedList<string> ReverseLinkedList1(LinkedList<string> list)
        {
            // iterate over the list nodes - while loop? Try looping backwards w/ Previous prop of nodes (start at Last)
            // need to make a new linked list in order to copy values - use array first?
            // as iterating backwards, copy values to array/list
            // pass array to new linked list

            // get last node of list so can iterate backwards
            LinkedListNode<string> node = list.Last;

            // need to get string value so can make copy of node
            string nodeString = list.Last.Value;
            LinkedListNode<string> copyNode = new LinkedListNode<string>(nodeString);

            // make a new Linked List to copy values
            LinkedList<string> reverseList = new LinkedList<string>();
            reverseList.AddFirst(copyNode);

            while (node.Previous != null)
            {
                string nextNodeString = node.Previous.Value;
                LinkedListNode<string> nextNode = new LinkedListNode<string>(nextNodeString);
                reverseList.AddAfter(copyNode, nextNode);
                node = node.Previous;
                copyNode = nextNode;
            }

            return reverseList;

        }

        static LinkedList<string> ReverseLinkedList2(LinkedList<string> list)
        {
            // get last node of list so can iterate backwards
            LinkedListNode<string> node = list.Last;

            // make an array to store values of list nodes
            string[] listValues = new string[list.Count];
            int count = 0;

            while (node != null)
            {
                string value = node.Value;
                listValues[count] = value;
                node = node.Previous;
                count++;
            }

            LinkedList<string> reverseList = new LinkedList<string>(listValues);
            return reverseList;
        }

        //Make a third version without using Previous (singly linked but manual)
        public static LinkedList<string> ReverseLinkedList3(LinkedList<string> list)
        {
            // get last node of list so can iterate backwards
            LinkedListNode<string> node = list.First;

            // make an array to store values of list nodes
            string[] listValues = new string[list.Count];
            int count = (list.Count - 1);

            while (node != null)
            {
                string value = node.Value;
                listValues[count] = value;
                node = node.Next;
                count--;
            }

            LinkedList<string> reverseList = new LinkedList<string>(listValues);
            return reverseList;
        }

        //Fourth version w/ Reverse method of List
        public static LinkedList<string> ReverseLinkedList4(LinkedList<string> list)
        {
            return new LinkedList<string>(list.Reverse());
        }

        public static LinkedList<string> ReverseLinkedList5(LinkedList<string> linkedList)
        {

            // use a List so I don't have to deal w/ indices of an array- avoid OutOfBounds errors
            // at end: double check that my while loop isn't off by one

            List<string> list = new List<string>();

            LinkedListNode<string> node = linkedList.Last;

            while (node != null)
            {

                list.Add(node.Value);
                node = node.Previous;
            }

            return new LinkedList<string>(list);

        }
    }
}
