using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//https://leetcode.com/problems/happy-number/?envType=study-plan-v2&envId=top-interview-150
namespace _25_merge_two_list
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var dic = new HashSet<int>();
            var sum = n;
            while (sum != 1)
            {
                if (dic.Contains(sum))
                {
                    return false;
                }
                dic.Add(sum);
                sum = GetSquareSum(sum);
            }
            return true;
        }

        private int GetSquareSum(int n)
        {
            var sum = 0;
            while( n > 0) {
                var digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            return sum;
        }
    }
}
