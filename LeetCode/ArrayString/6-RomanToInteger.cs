using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romDic = new Dictionary<char, int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romDic[s[i]] < romDic[s[i + 1]])
                {
                    result -= romDic[s[i]];
                }
                else
                {
                    result += romDic[s[i]];
                }
            }
            return result;
        }
    }
}