using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17_index_occurrence;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/?envType=study-plan-v2&envId=top-interview-150

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int needleLength = needle.Length;

        for (int i = 0; i <= haystack.Length - needleLength; i++)
        {
            if (haystack.Substring(i, needleLength) == needle)
                return i;
        }

        return -1;
    }

    public int StrStr2(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        int i = 0,
            j = 0;
        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                j++;
            }
            else
            {
                i -= j;
                j = 0;
            }
            i++;
            if (j == needle.Length)
            {
                return i - needle.Length;
            }
        }
        return -1;
    }

    public int StrStr3(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
