using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_remove_duplicates_array
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int result = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[result++] = nums[i];
                }
            }

            return result;
        }
    }
}