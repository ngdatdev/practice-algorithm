using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_maximum_depth_binary
{

    // https://leetcode.com/problems/maximum-depth-of-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1; 
        }

    }
}