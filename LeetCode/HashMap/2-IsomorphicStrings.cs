using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dictionary1 = new Dictionary<char, char>();

            foreach (char c in s)
            {
                foreach (char d in t)
                {
                    //dictionary1.Add();
                    break;
                }
            }
            return true;
        }
    }
}
