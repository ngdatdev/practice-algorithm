using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _31_rotate_array;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var length = nums.Length;
        k %= length;
        var temp = new int[length];

        for(int i = 0; i < length; i++) {
            temp[(i + k) % length] = nums[i];
        }
        for(int i = 0; i < length; i++) {
            nums[i] = temp[i];
        }
    }
}
