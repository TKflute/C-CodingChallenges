using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class FindNthNode
    {
        // How to remove Nth node from end of Linked List
        // red -> orange -> yellow -> green -> blue
        // N = 3 -> Remove 'yellow'

        // get a hold of last Node
        // iterate n -1 times
        // then can break out of iteration
        // remove that node have hold of - should be correct node
        // shouldn't need access to the count/length of list
        // should be able to do everything w/ a linked list

        public static void RemoveNthNodeFromLast(LinkedList<string> linkedList, int n)
        {

            LinkedListNode<string> node = linkedList.Last;

            for (int i = 1; i < n; i++)
            {
                node = node.Previous;
            }

            linkedList.Remove(node);
        }



        // How to remove Nth node from end of Singly Linked List (can't iterate backwards)
        // red -> orange -> yellow -> green -> blue
        // N = 3 -> Remove 'yellow'

        // key with this one: will need two pointers : call them endPointer and nthPointer
        // get a hold of First Node and store as endPointer
        // iterate n -1 times forward and bump up endPointer
        // set nthPointer to first node
        // then keep iterating to end of list, and bump each pointer up once each iteration
        // after loop, remove or return nthPointer
        public static void RemoveNthNodeFromLastSinglyLinked(LinkedList<string> linkedList, int n)
        {
            // note: at end, double check for off by one errors

            LinkedListNode<string> endPointer = linkedList.First;
            LinkedListNode<string> nthPointer = linkedList.First;

            for (int i = 1; i < n; i++)
            {

                endPointer = endPointer.Next;
            }

            for (int i = n; i < linkedList.Count; i++)
            {

                nthPointer = nthPointer.Next;
                endPointer = endPointer.Next;
            }

            linkedList.Remove(nthPointer);
        }
    }
}
