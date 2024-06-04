using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_merge_sorted_list
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1.val >= list2.val) {
                list2.next = MergeTwoLists(list1.next, list2);
            } else {
                
            }

            
            return list1;
        }
    }

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
}