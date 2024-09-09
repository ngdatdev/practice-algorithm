using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27_group_anagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                 var sortStr = new string(chars);
                if (!dic.TryGetValue(sortStr, out var arr))
                {
                    dic[sortStr] = new List<string>();
                }
                dic[sortStr].Add(str);
            }

            return new List<IList<string>>(dic.Values);
        }
    }
}
