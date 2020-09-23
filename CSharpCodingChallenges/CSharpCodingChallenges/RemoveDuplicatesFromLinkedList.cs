using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodingChallenges
{
    class RemoveDuplicatesFromLinkedList
    {
        // Initial notes:
        // How are duplicate nodes removed in an unsorted LinkedList?
        // use a while loop to iterate over list
        // compare values
        // try and avoid double loops- should be able to
        // is there a sort method I can use on a LinkedList?
        // is there a duplicate method? - later- there is .Distinct() using LINQ, but not for LL, only List
        // you could get LinkedList values and put in a set ***- then put values back into linked List
        public static LinkedList<string> RemoveDuplicateNodes(LinkedList<string> linkedList)
        {
            // First version
            //HashSet<string> set = new HashSet<string>();
            //LinkedListNode<string> node = linkedList.First;

            //while (node != null)
            //{

            //    set.Add(node.Value);
            //    node = node.Next;
            //}

            //string[] values = new string[set.Count];
            //int i = 0;
            //foreach(string value in set)
            //{
            //    values[i++] = value;
            //}

            //return new LinkedList<string>(values);

            // Version 2 - this works! So my thinking of using a Set was good - it's actually less code than below
            HashSet<string> set = linkedList.ToHashSet<string>();
            return new LinkedList<string>(set.ToList());
        }

        public static LinkedList<string> RemoveDuplicateNodesI(LinkedList<string> linkedList)
        {
            // to use Distinct, would have to convert to a List first
            //List<string> list = linkedList.ToList();
            return new LinkedList<string>(linkedList.Distinct().ToList());
            //list = list.Distinct().ToList();
            //linkedList = new LinkedList<string>(list);
            //return linkedList;
        }
    }
}
