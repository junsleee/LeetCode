using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.ArrayString;

namespace LeetCodeTest.ArrayStringTest
{
    public class MajorityElementTests
    {
        [TestMethod()]
        public void MajorityTest()
        {
            //arrange
            MajorityElement mE = new MajorityElement();
            int[] nums1 = [3, 2, 3];
            int expected = 3;
            //act
            int attempt = mE.Majority(nums1);
            //assert
            Assert.AreEqual(expected, attempt);
        }
    }
}