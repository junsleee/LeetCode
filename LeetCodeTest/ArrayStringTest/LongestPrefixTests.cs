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
    public class LongestPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            string[] strs = ["flower", "flow", "flight"];
            string expected = "fl";
            LongestPrefix l = new();

            string actual = l.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LongestCommonPrefixTest2()
        {
            string[] strs = ["dog", "racecar", "car"];
            string expected = "";
            LongestPrefix l = new();

            string actual = l.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, actual);
        }
    }
}