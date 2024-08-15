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
    public class RomanToIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            RomanToInteger rTI = new RomanToInteger();
            string romNum = "III";
            int expected = 3;
            int attempt = rTI.RomanToInt(romNum);
            Assert.AreEqual(expected, attempt);
        }
    }
}