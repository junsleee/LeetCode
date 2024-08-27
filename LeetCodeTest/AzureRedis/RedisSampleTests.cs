using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.AzureRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AzureRedis.Tests
{
    [TestClass()]
    public class RedisSampleTests
    {
        [TestMethod()]
        public void AddToSetTest()
        {
            new RedisSample().AddToSet("Jun", "Hello World");
        }
        [TestMethod()]
        public void GetFromSetTest()
        {
            string actual = new RedisSample().GetValueFromSet("Jun");
            string expected = "Hello World";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetContains()
        {
            bool actual = new RedisSample().SetContains("Jun", "Hello World");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}