using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _26_contains_duplicate_II
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //1 (n^2)
            // for int length nums.
            // for int k

            //2 (n)
            // for int length nums
            // Check is element exist in dic
            // if not add to dic
            // if exist Find index this number
            // Length hash - index
            // Return if true
            // Else edit value to current value.

            int length = nums.Length;
            var hashTable = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (!hashTable.TryAdd(nums[i], i))
                {
                    hashTable.TryGetValue(nums[i], out var index);
                    var distance = i - index;
                    if (distance <= k)
                    {
                        return true;
                    }

                    hashTable[nums[i]] = i;
                }
            }

            return false;
        }
    }
}
