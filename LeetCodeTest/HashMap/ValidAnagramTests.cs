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
    public class ValidAnagramTests
    {
        public void AnagramTest()
        {
            ValidAnagram vA = new ValidAnagram();

            string s = "anagram";
            string t = "nagaram";
            bool expected = true;
            bool actual = vA.Anagram(s, t);

            Assert.AreEqual(expected, actual);
        }
    }
}