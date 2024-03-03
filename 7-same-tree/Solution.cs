using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace _7_same_tree
{

    // https://leetcode.com/problems/same-tree/description/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q) {
            if(p == null && q == null) {
                return true;
            }
            if(p == null || q == null) {
                return false;
            }
            if(p.val != q.val) {
                return false;
            } 
            bool a = IsSameTree(p.left, q.left);
            bool b = IsSameTree(p.right, q.right);

            return a && b;
        }
    }
}