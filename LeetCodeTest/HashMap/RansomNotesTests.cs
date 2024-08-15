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
    public class RansomNotesTests
    {
        [TestMethod()]
        public void RansomNoteTest()
        {
            RansomNotes ransom = new RansomNotes();

            string mag = "aa";
            string rans = "aab";
            bool expected = false;
            bool attempt = ransom.RansomNote(rans, mag);

            Assert.AreEqual(expected, attempt);
        }
        [TestMethod()]
        public void RansomNoteTest2()
        {
            RansomNotes ransom = new RansomNotes();

            string mag = "ab";
            string rans = "aa";
            bool expected = false;
            bool attempt = ransom.RansomNote(rans, mag);

            Assert.AreEqual(expected, attempt);
        }
        [TestMethod()]
        public void RansomNoteTest3()
        {
            RansomNotes ransom = new RansomNotes();

            string mag = "a";
            string rans = "b";
            bool expected = false;
            bool attempt = ransom.RansomNote(rans, mag);

            Assert.AreEqual(expected, attempt);
        }
    }
}