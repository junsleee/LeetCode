using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class RansomNotes
    {
        public bool RansomNote(string ransomNote, string magazine)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            foreach (char d in ransomNote)
            {
                if ((dictionary.ContainsKey(d)) && (dictionary[d] > 0))
                {
                    dictionary[d]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
