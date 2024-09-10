using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Length == 0) return 0;

            int start = 0;
            int end = 0;
            int windowSum = nums[0];
            int maxLen = int.MaxValue;

            while (end < nums.Length)
            {
                if (windowSum < target)
                {
                    end++;
                    if (end < nums.Length)
                    {
                        windowSum += nums[end];
                    }
                }
                else
                {
                    maxLen = Math.Min(maxLen, end - start + 1);
                    windowSum -= nums[start];
                    start++;
                }
            }
            return maxLen == int.MaxValue ? 0 : maxLen;
        }
    }
}
