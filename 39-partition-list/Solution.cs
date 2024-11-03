using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _39_partition_list
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
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            
            ListNode lessHead = new ListNode(0);
            ListNode less = lessHead;
            ListNode greaterHead = new ListNode(0);
            ListNode greater = greaterHead;
            ListNode cur = head;
            while(cur != null) {
                if(cur.val >= x) {
                    greater.next = cur;
                    greater = greater.next;
                } else {
                    less.next = cur;
                    less = less.next;
                }
                cur = cur.next;
            }
            greater.next = null;
            less.next = greaterHead.next;

            return lessHead.next;
        }
    }
}
