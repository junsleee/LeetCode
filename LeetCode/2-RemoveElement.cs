using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveElement
    {
        public int Remove(int[] nums, int val)
        {
            int x = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == val) continue;
                else nums[x] = nums[i];
                x += 1;
            }
            return x;
        }
    }
}
