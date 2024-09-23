using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_sumary_ranges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();

            if (nums.Length == 0)
            {
                return default;
            }

            int startKey = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    if (i == startKey + 1)
                    {
                        result.Add(nums[i - 1].ToString());
                    } 
                    else {
                        result.Add(nums[startKey].ToString() + "->" + nums[i - 1].ToString());
                    }
                }
            }
            return result;
        }
    }
}
