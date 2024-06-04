using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_length_last_word;

//https://leetcode.com/problems/length-of-last-word/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string sTrim = s.Trim();
        int lastIndex = sTrim.Length - 1;
        int result = 0;
        for (int i = lastIndex; i >= 0; i--)
        {
            if (Equals(sTrim[i], ' '))
            {
                break;
            }
            result++;
        }
        return result;
    }
}
