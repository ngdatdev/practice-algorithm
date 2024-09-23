using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29_longest_consequenive
{
    public class Solution
    { //[100,4,200,1,3,2]
        public int LongestConsecutive(int[] nums)
        {
            var hash = new HashSet<int>();
            var temp = 0;

            foreach (var item in nums)
            {
                hash.Add(item);
            }

            for (int i = 0; i < hash.Count(); i++)
            {
                if (hash.Contains(nums[i] + 1))
                {
                    temp++;
                }
            }
            return temp + 1;
        }
    }
}
