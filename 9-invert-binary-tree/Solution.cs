using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_invert_binary_trê
{
    // https://leetcode.com/problems/invert-binary-tree/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            if (root.left == null && root.right == null)
            {
                return root;
            }
            else
            {
                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;
            }
            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);
            return root;
        }

 
        public TreeNode InvertTree2(TreeNode root) {
            if(root == null) {
                return null;
            }

            return new TreeNode(val: root.val, 
            root.left = InvertTree2(root.right),
            root.right = InvertTree2(root.left));
        }
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