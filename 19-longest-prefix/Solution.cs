using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_longest_prefix
{
    //https://leetcode.com/problems/longest-common-prefix/submissions/1282873302/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder stringBuilder = new();
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length - 1];
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != last[i])
                {
                    return stringBuilder.ToString();
                }
                stringBuilder.Append(first[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
