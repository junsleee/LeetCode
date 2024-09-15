using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class LongestConsecutive
    {
        public int LongestConsecutiveSequence(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> numSet = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (int num in numSet)
            {
                // only count when it's the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    //check the next consecutive numbers
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }
    }
}
