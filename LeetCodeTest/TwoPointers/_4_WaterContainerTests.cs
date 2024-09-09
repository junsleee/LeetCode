using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers.Tests
{
    [TestClass()]
    public class WaterContainerTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            WaterContainer waterContainer = new WaterContainer();

            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            int expected = 49;
            int actual = waterContainer.MaxArea(height);

            Assert.AreEqual(49, actual);
        }
    }
}