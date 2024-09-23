using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_merge_2_list
{
    //https://leetcode.com/problems/merge-two-sorted-lists/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Traverse through both lists
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }
            return dummy.next;
        }
    }
}
