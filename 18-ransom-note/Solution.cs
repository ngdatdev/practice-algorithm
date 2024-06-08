using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_ransom_note;

// https://leetcode.com/problems/ransom-note/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> keyValuePairs = [];
        foreach (char c in magazine)
        {
            if (keyValuePairs.ContainsKey(c))
            {
                keyValuePairs[c]++;
            }
            else
            {
                keyValuePairs[c] = 1;
            }
        }

        foreach (char c in ransomNote)
        {
            if (
                !keyValuePairs.TryGetValue(c, out int value)
                || keyValuePairs.GetValueOrDefault(c, 0) == 0
            )
            {
                return false;
            }
            keyValuePairs[c] = --value;
        }

        return true;
    }
}
