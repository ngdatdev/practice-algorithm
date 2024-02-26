using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//https://leetcode.com/problems/binary-search/submissions/1186981486/

namespace search_binary
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int length = nums.Length - 1;
            int start = 0;
            int end = length;
            int middle;
            while (end >= start)
            {
                middle = (start + end) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                if (nums[middle] > target)
                {
                    end = middle - 1;
                }
                if (nums[middle] < target)
                {
                    start = middle + 1;
                }

            }
            return -1;
        }
    }
}