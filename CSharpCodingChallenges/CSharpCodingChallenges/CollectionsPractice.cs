using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class CollectionsPractice
    {
        public static void MessingWithCollections()
        {
            string[] values = {"Hello", "World", "How", "are", "you" };
            string[] values2 = new string[2] { "hello", "world" };
            string[] values3 = new string[3];
            values3[0] = "hi";
            values3[1] = "Good";
            values3[2] = "day";
            Array.Sort(values);

            // can pass an array to many collections when initializing without doing any explicit conversion
        
            List<string> list = new List<string>(values);
            list.Add("new value");
            list.Add("new value"); // valid- lists can store dups
            list.Remove("new value");
            list.Add(null); // valid- lists can store mult nulls
            list.Add(null);
            int count = 0;

            Console.WriteLine("List:\n");
            foreach(string value in list)
            {
                Console.WriteLine(count + ": " + value);
                count++;
            }

            HashSet<string> hashSet = new HashSet<string>(values);
            string newValue = "new value!";
            hashSet.Add(newValue);
            hashSet.Add(newValue); // this isn't giving a compiler error, but Sets can't have dups - doesn't show in print, but doesn't throw Exception
           // hashSet.Add(null); //INVALID: will throw a NullReverenceException - sets can't have nulls

            Console.WriteLine("HashSet:\n");
            foreach(string value in hashSet)
            {
                Console.WriteLine(value.GetHashCode() + ": " + value);
            }

            LinkedList<string> linkedList = new LinkedList<string>(values);
            Console.WriteLine("LinkedList:\n");
            foreach (string value in linkedList)
            {
                Console.WriteLine("Value: {0} NextNode:? Can't access pointers/node methods with foreach!", value);
            }
            LinkedListNode<string> node = linkedList.First;
            while(node != null)
            {
                if(node.Next == null){
                    Console.WriteLine("Value: {0} NextNode w/ while loop on nodes: NULL", node.Value);
                }
                else
                {
                    Console.WriteLine("Value: {0} NextNode w/ while loop on nodes: {1}", node.Value, node.Next.Value);
                }
                node = node.Next;
            }

            Queue<string> queue = new Queue<string>(values);
            queue.Enqueue("Foo");
            string firstInLinePeek = queue.Peek();
            Console.WriteLine("Queue:\n");
            Console.WriteLine("First in line peek: " + firstInLinePeek);
            Console.WriteLine("Removing first in line w/ Dequeue...");
            string firstInLine = queue.Dequeue();
            foreach (string value in queue)
            {
                Console.WriteLine(value);
            }

            Stack<string> stack = new Stack<string>(values);
            stack.Push("Foo");
            string topOfStackPeek = stack.Peek();
            Console.WriteLine("Stack:\n");
            Console.WriteLine("Top of Stack Peek: " + topOfStackPeek);
            string topOfStack = stack.Pop();
            Console.WriteLine("Removing top of stack w/ Pop...");
            foreach(string value in stack)
            {
                Console.WriteLine(value);
            }
           
            // PICK UP HERE: Do same thing with Dictionary, then try sorting, reversing, searching, and clearing each collection
            // Do more operations w/ LinkedList- AddFirst, AddLast, RemoveFirst, RemoveLast, Remove(T), AddAfter, AddBefore
            
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            int key = 1;
            foreach(string value in values)
            {
                keyValuePairs.Add(key, value);
                key++;
            }
            Console.WriteLine("Dictionary:\n");
            foreach(KeyValuePair<int, string> kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key + ": " +  kvp.Value);
                if (kvp.Value.Equals("Hello"))
                {
                    Console.WriteLine("Key for value of Hello: " + kvp.Key);
                }
            }
            
            Console.WriteLine("Dictionary keys:\n");
            Dictionary<int, string>.KeyCollection keys = keyValuePairs.Keys;
            foreach(int keyInt in keys)
            {
                Console.WriteLine(keyInt);
            }
            Console.WriteLine("Dictionary values:\n");
            Dictionary<int, string>.ValueCollection valueCollection = keyValuePairs.Values;
            foreach(string v in valueCollection)
            {
                Console.WriteLine(v);
            }

            keyValuePairs.Add(key, "new value");
            Console.WriteLine(keyValuePairs[6]);
            
           
        }
    }
}
