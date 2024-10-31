using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace _36_remove_n_linkedlist
{
    public class Solution2
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            ListNode dummy = new();
            ListNode listNode = dummy;
            listNode.next = head;
            ListNode prev = listNode;

            for (int i = 0; i < n; i++)
            {
                listNode = listNode.next;
            }
            while (listNode.next != null)
            {
                prev = prev.next;
                listNode = listNode.next;
            }
            prev.next = prev.next.next;
            return dummy.next;
        }
    }
}
