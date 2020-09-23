using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingChallenges
{
    class BinarySearchExample
    {
        public static int BinarySearchRecursive(int target, int[] arr, int l, int u)
        {
            // **KEY for BinarySearch: array MUST be sorted!!**
            // assign upper and lower bounds (if not passed in, need to pass to do recursively w/out loop)
            // start looking at middle index
            // keep searching until lower bound is <= upper (while loop)
            // inside while loop, if statements
            // keep reassigning middle/bounds accordingly
            // return index of value or -1 if array does not contain

            int m = (l + u) / 2;

            if (arr[m] == target)
            {
                // base case (breaks recursion)
                return m;
            }
            else if (arr[m] > target)
            {
                // search left
                // recursive case (triggers recursion)
                return BinarySearchRecursive(target, arr, l, m - 1);
            }
            else if (arr[m] < target)
            {
                // search right 
                return BinarySearchRecursive(target, arr, m + 1, u);
            }

            return -1;

        }

        public static int BinarySearch(int target, int[] arr, int l, int u)
        {
            // assign upper and lower bounds
            // start looking at middle index
            // keep searching until lower bound is <= upper (while loop)
            // inside while loop, if statements
            // keep reassigning middle/bounds accordingly
            // return index of value or -1 if array does not contain

            while (l <= u)
            {
                int m = (l + u) / 2;

                if (arr[m] == target)
                {
                    return m;
                }
                else if (arr[m] > target)
                {
                    // search left
                    u = m - 1;
                }
                else
                {
                    // search right (arr[m] < target)
                    l = m + 1;
                }
            }

            return -1;
        }
    }
}
