using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class FindMiddleNodeOfLinkedList
    {
        // find the middle element of a singly linked list in one pass?
        // one pass -> one iteration over the list nodes? Unaware of a get method for nodes based on value

        public static LinkedListNode<string> FindMiddleNode(LinkedList<string> linkedList)
        {

            // find half of count 
            // ex. list of 5 nodes => 5/2 = 2, middle index is 2 (if there were an index)
            // list of 6 nodes => 6/2 = 3 - just keep it default so will be right heavy

            int middleNum = linkedList.Count / 2;
            LinkedListNode<string> node = linkedList.First;
            int count = 1;
            while (count <= middleNum)
            {
                node = node.Next;
                count++;
            }
            return node;
        }

        public static LinkedListNode<string> FindMiddleNodeNoCount(LinkedList<string> linkedList)
        {
            LinkedListNode<string> node = linkedList.First;
            LinkedListNode<string> middle = linkedList.First;

            int count = 1;
            while (node != null)
            {
                node = node.Next;
                count++;
                if (count % 2 == 1)
                {
                    middle = middle.Next;
                }
            }
            return middle;
        }

    }
}
