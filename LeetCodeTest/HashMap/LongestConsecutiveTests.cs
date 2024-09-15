using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap.Tests
{
    [TestClass()]
    public class LongestConsecutiveTests
    {
        [TestMethod()]
        public void LongestConsecutiveSequenceTest()
        {
            LongestConsecutive sequence = new LongestConsecutive();

            int[] nums = [100, 4, 200, 1, 3, 2];

            int expected = 4;
            int actual = sequence.LongestConsecutiveSequence(nums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestConsecutiveSequenceTest2()
        {
            LongestConsecutive sequence = new LongestConsecutive();

            int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

            int expected = 9;
            int actual = sequence.LongestConsecutiveSequence(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}