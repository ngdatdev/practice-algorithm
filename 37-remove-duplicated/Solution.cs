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
            ListNode prev = new(0);
            ListNode current = head;
            ListNode result = prev;
            var isDuplicate = false;
            while (current != null && current.next != null)
            {
                if (current.val != current.next.val)
                {
                    if (!isDuplicate)
                    {
                        prev.next = current;
                        prev = prev.next;
                    } else {
                        isDuplicate = false;
                    }
                }
                else
                {
                    isDuplicate = true;
                }
                current = current.next;
            }

            return result.next;
        }
    }
}
