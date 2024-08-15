using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.ArrayString;

namespace LeetCodeTest.ArrayStringTest
{
    [TestClass()]
    public class BestTimeToBuySellStockTests
    {
        [TestMethod()]
        public void maxProfitTest()
        {
            //arrange
            BestBuySell mBS = new BestBuySell();
            //act
            int[] num1 = [7, 1, 5, 3, 6, 4];
            int expected = 5;
            int attempt = mBS.MaxProfit(num1);
            //assert
            Assert.AreEqual(5, attempt);
            //CollectionAssert.AreEqual(expected, num1[0..attempt]);
        }
    }
}