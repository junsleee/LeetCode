using Microsoft.Extensions.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            // one-pass hash table
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { };


            // brute force
            // time = O(n^2) for each element, loop through the rest of the array which is another O(n)
            // space = O(1), space required doesn't depend on size of the input array

            // for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[j] == target - nums[i]) 
            //        {
            //            return new int[] { i, j };
            //        }
            //    }
            //}
            //return new int[] { };
        }
    }
}
