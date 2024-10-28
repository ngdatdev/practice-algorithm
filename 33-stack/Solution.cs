using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _33_stack
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] openBrackets = ['(', '{', '['];
            char[] closeBrackets = [')', '}', ']'];

            // Sử dụng stack để theo dõi các ký tự mở
            var stack = new List<char>();

            foreach (char c in s)
            {
                if (openBrackets.Contains(c))
                {
                    stack.Add(c);
                }
                else if (closeBrackets.Contains(c))
                {
                    var temp = Array.IndexOf(closeBrackets, c);
                    if (stack.Count == 0 || stack[^1] != openBrackets[temp])
                    {
                        return false;
                    }
                    stack.RemoveAt(stack.Count - 1);
                }
            }

            return stack.Count == 0;
        }
    }
}
