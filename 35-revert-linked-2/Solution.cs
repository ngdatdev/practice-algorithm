using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _35_revert_linked_2
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

    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode result = head;
            ListNode prev = head;
            for (int i = 1; i < left - 1; i++)
            {
                prev = prev.next;
            }
            ListNode current = prev.next;
            for (int i = left; i < right; i++)
            {
                ListNode forw = current.next;
                current.next = forw.next;
                forw.next = prev.next;
                prev.next = forw;
            }

            return result;
        }
    }
}
