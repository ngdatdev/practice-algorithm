using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _22_follow_pattern
{
    // https://leetcode.com/problems/word-pattern/description/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(" ");
            if (words.Length != pattern.Length)
            {
                return false;
            }
            var dicPattern = new Dictionary<char, string>();
            var dicS = new Dictionary<string, char>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string word = words[i];
                if (!dicPattern.ContainsKey(c))
                {
                    dicPattern.Add(c, word);
                }
                if (!dicS.ContainsKey(word))
                {
                    dicS.Add(word, c);
                }

                if (
                    !dicPattern.GetValueOrDefault(c).Equals(word)
                    || !dicS.GetValueOrDefault(word).Equals(c)
                )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
