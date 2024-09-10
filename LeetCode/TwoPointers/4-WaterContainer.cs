using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class WaterContainer
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = -1;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
            //some change attempt 2
        }
    }
}
