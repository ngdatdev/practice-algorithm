using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _37_remove_duplicated
{
    public class Solution2
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummy = new(0, head);

            ListNode result = dummy;
            ListNode current = head;
            ListNode prev = new(0);
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
