using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow.Tests
{
    [TestClass()]
    public class MinimumSizeSubarraySumTests
    {
        [TestMethod()]
        public void MinSubArrayLenTest()
        {
            var solution = new MinimumSizeSubarraySum();
            int target = 7;
            int[] nums = [2, 3, 1, 2, 4, 3];

            int result = solution.MinSubArrayLen(target, nums);

            Assert.AreEqual(target, result);
        }
    }
}