using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_symmetric_tree
{
    //https://leetcode.com/problems/symmetric-tree/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return Traverse(root.right, root.left);
        }
        public bool Traverse(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            else if (node1 == null || node2 == null)
            {
                return false;
            }
            return node1.val == node2.val && Traverse(node1.left, node2.right) && Traverse(node1.right, node2.left);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}