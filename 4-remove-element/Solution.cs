using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_remove_element
{

    // https://leetcode.com/problems/remove-element/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[result++] = nums[i];
                }
            }
            return result;

        }
    }
}