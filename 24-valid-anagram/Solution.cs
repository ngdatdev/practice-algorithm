using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24_valid_anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> result = [];

            for (int i = 0; i < s.Length; i++)
            {
                if (!result.TryAdd(s[i], 1))
                {
                    result[s[i]] = result[s[i]] + 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (result.ContainsKey(t[i]))
                {
                    result[t[i]] = result[t[i]] - 1;
                    // if (result[t[i]] == 0)
                    // {
                    //     result.Remove(t[i]);
                    // }
                }
                else if(result[t[i]] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
