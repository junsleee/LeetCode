using System.Numerics;

namespace LeetCode
{ //https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&envId=top-interview-150
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0) { Array.Copy(nums2, nums1, nums2.Length); return; }

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    (nums1[i], nums1[m - 1]) = (nums1[m - 1], nums1[i]);
                    m -= 1;
                }
                else
                {
                    (nums1[i], nums2[n - 1]) = (nums2[n - 1], nums1[i]);
                    n -= 1;
                    if (n == 0) break;
                }
            }
        }
    }
}
/* nums1 = [1, 2, 3, 0, 0, 0]
 * m = 3
 * nums2 = [2, 5, 6]
 * n = 3
 * merging [1, 2, 3] , [2, 5, 6]
 * output: nums1 = [1, 2, 2, 3, 5 ,6]
 */

