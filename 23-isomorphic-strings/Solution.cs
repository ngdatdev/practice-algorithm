using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _23_isomorphic_strings
{
    //https://leetcode.com/problems/isomorphic-strings/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
         public bool IsIsomorphic(string s, string t) {
            Dictionary<char, int> resultS = new();
            Dictionary<char, int> resultT = new();

            if(s.Length != t.Length) {
                return false;
            }

            for(int i = 0; i < s.Length; i++) {
                var charS = s[i];
                var charT = t[i];
                if(!resultS.ContainsKey(s[i])) {
                    resultS.Add(charS, i + 1);
                }
                if(!resultT.ContainsKey(t[i])) {
                    resultT.Add(charT, i + 1);
                }
                if(resultS.GetValueOrDefault(charS) != resultT.GetValueOrDefault(charT)) {
                    return false;
                }
            }

            return true;
        }
    }
}