using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_two_sum
{
    // https://leetcode.com/problems/two-sum/solutions/3619262/3-method-s-c-java-python-beginner-friendly/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) { 
            int n = nums.Length;

            for(int i = 0; i < n; i++) {
                var temp = target - nums[i];
                for(int j = i-1; j>= 0; j--) {
                    if(temp == nums[j]) {
                        return new int[] {j, i};
                    }

                }
            }
            return new int[] {0, 0};
        }
    }
}
