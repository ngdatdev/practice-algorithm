using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _36_remove_n_linkedlist
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            ListNode listNode = Revert(head);
            ListNode result = new();
            result.next = listNode; // 2 va 1
            ListNode dummy = result;
            ListNode prev = null;
            for (int i = 0; i < n; i++) { 
                prev = result;
                result = result.next;
            }
            prev.next = result.next;
            if(dummy.next != null) {
                dummy = Revert(dummy.next);

            } else {
                dummy = null;
            }
            return dummy;
        }

        public ListNode Revert(ListNode head)
        {
            ListNode listNode = new ListNode(head.val);
            head = head.next;
            while (head != null)
            {
                listNode = new(head.val, listNode);
                head = head.next;
            }
            return listNode;
        }
    }
}
