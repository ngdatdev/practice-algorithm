using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_is_subsequence
{
    // https://leetcode.com/problems/is-subsequence/submissions/1195701910/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool IsSubsequence(string s, string t) {
        int i = s.Length - 1;
        int j = t.Length - 1;

        while(i != -1 && j != -1) {
            if(s[i] == t[j]) {
                i--;
            }
            j--;
        }
        return i == -1;
    }
    }
}