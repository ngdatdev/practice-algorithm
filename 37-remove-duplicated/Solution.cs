using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _37_remove_duplicated
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
        public ListNode DeleteDuplicates(ListNode head)
           {
            if(head == null)
                return null;

            ListNode dummy = new(-101);
            ListNode result = dummy;
            ListNode current = head;
            ListNode prev = new(-101);
            while (current != null && current.next != null)
            {
                if (current.val != current.next.val && prev.val != current.val)
                {
                    dummy.next = new(current.val);
                    dummy = dummy.next;
                }
                prev = current;
                current = current.next;
            }

            if(prev.val != current.val)
                dummy.next = new(current.val);

            return result.next;
        }
    }
}
