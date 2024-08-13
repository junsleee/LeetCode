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
    public class RemoveElementTests
    {
        [TestMethod()]
        public void removeElementTest()
        {
            //arrange
            RemoveElement r = new RemoveElement();
            //act
            int[] num1 = [3, 2, 2, 3];
            int val = 3;
            int[] expected = [2, 2];
            int attempt = r.Remove(num1, val);
            //assert
            Assert.AreEqual(2, attempt);
            CollectionAssert.AreEqual(expected, num1[0..attempt]);
        }
    }
}