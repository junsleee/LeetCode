using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSort
    {
        public int[] SortMerge(int[] input, int v)
        {
            if (input.Length == 1) return input;
            int mid = input.Length / 2;
            int[] left = input[..mid];
            int[] right = input[mid..];

            //base case: array is all sorted 
            //if ()

            //recursion
            return SortMerge(input, v);
        }
    }
}
