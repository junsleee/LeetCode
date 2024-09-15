using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = [0, 1];
            int[] actual = twoSum.TwoSums(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest2()
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] expected = [1, 2];
            int[] actual = twoSum.TwoSums(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TwoSumTest3()
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            int[] expected = [0, 1];
            int[] actual = twoSum.TwoSums(nums, target);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}