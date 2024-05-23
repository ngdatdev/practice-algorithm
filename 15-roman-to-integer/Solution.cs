using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15_roman_to_integer
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romans = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (romans.GetValueOrDefault(s[i]) < romans.GetValueOrDefault(s[i + 1]))
                {
                    result -= romans.GetValueOrDefault(s[i]);
                }
                else
                {
                    result += romans.GetValueOrDefault(s[i]);
                }
            }

            return result + romans.GetValueOrDefault(s[s.Length - 1]);
        }
    }
}
