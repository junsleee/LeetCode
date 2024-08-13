using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            //arrange
            RemoveDuplicatesFromSortedArray rD = new RemoveDuplicatesFromSortedArray();
            //act
            int[] nums = [1, 1, 2];
            int[] expected = [1, 2];
            int attempt = rD.RemoveDuplicates(nums);
            //assert
            Assert.AreEqual(2, attempt);
            CollectionAssert.AreEqual(expected, nums[0..attempt]);
        }
    }
}