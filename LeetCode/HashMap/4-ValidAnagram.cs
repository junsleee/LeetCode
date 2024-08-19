using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class ValidAnagram
    {
        public bool Anagram(string s, string t)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary.Add(c, 1);
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            foreach (char d in t)
            {
                if (dictionary.ContainsKey(d))
                {
                    if (dictionary[d] == 1)
                    {
                        dictionary.Remove(d);
                    }
                    else
                    {
                        dictionary[d] -= 1;
                    }
                }
                else
                {
                    return false;
                }
            }
            return dictionary.Count == 0;
        }
    }
}
