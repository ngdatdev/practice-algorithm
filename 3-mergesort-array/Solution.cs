using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_mergesort_array
{
    public class Solution
    {
        public int[] MergeSort(int[] nums1, int m, int[] nums2, int n)
        {
            int q = m + n - 1;
            m--;
            n--;
            while (n >= 0)
            {
                if (m >= 0 && nums1[m] > nums2[n])
                {
                    nums1[q--] = nums1[m--];
                }
                else
                {
                    nums1[q--] = nums2[n--];
                }
            }
            return nums1;
        }

    }
}