using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _38_rotate_right
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
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
                return head;

            int count = 1;
            ListNode tail = head;
            while (tail.next != null)
            {
                count++;
                tail = tail.next;
            }

            k = k % count;
            if (k == 0) return head;

            ListNode newTail = head;
            for(int i = 1; i < count - k; i++) {
                newTail = newTail.next;
            }

            ListNode newHead = newTail.next;
            newTail.next = null;
            tail.next = head;
            return newHead;
        }
    }
}
