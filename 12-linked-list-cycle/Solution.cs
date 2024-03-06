using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_linked_list_cycle
{
    //https://leetcode.com/problems/linked-list-cycle/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            Dictionary<ListNode, int> values = new Dictionary<ListNode, int>();
            ListNode current = head;
            while(current != null) {
                if(values.ContainsKey(current)) {
                    values[current]++;
                    if(values[current] == 2) {
                        return true;
                    }
                } else {
                    values.Add(current, 1);
                }
                current = current.next;
            }
            return false;
        }

        public bool HasCycle2(ListNode head)
        {
            ListNode node1 = head;
            ListNode node2 = head;
            while(node2 != null) {
                node1 = node1.next;
                node2 = node2.next.next;
                if(node1 == node2) {
                    return true;
                }
            }
            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}