using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13_valid_palindrome
{
    //https://leetcode.com/problems/valid-palindrome/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool IsPalindrome(string s)

        {
            if (s == null)
            {
                return true;
            }

            string snew = s.ToLower();
            int head = 0;
            int tail = snew.Length - 1;
            while (head < tail)
            {
                if (!char.IsLetterOrDigit(snew[head]))
                {
                    head++;
                }
                else if (!char.IsLetterOrDigit(snew[tail]))
                {
                    tail--;
                }
                else if (snew[head] != snew[tail])
                {

                    return false;
                }
                else
                {
                    head++;
                    tail--;
                }

            }
            return true;
        }
    }
}