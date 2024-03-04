using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_majority_element
{
    // https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            return nums[n/2];
        }

        public int MajorityElement2(int[] nums)
        {
            int count = 0;
            int value = 0;
            foreach(var num in nums) {
                if(count == 0) {
                    value = num;
                }
                if(value == num) {
                    count++;
                } else {
                    count--;
                }
            }
            return value;
        }

        public int MajorityElement3(int[] nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach(var num in nums) {
                if(pairs.ContainsKey(num)) {
                    pairs[num]++;
                } else {
                    pairs.Add(num, 1);
                }
                if(pairs[num] > nums.Length) {
                    return num;
                }
            }
            return -1;
        }
    }
}