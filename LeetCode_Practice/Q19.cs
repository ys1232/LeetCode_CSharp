using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singly_Linked_List;


namespace LeetCode_Practice
{
    class Q19
    {
        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode NodeHolder = head;
                int Length = 0;
                while (NodeHolder != null)
                {
                    Length++;
                    NodeHolder = NodeHolder.next;
                }

                

                int position_to_Remove = Length - n + 1;
                int current_position = 1;
                NodeHolder = head;
                ListNode NewList = NodeHolder;

                while (current_position < position_to_Remove - 1)
                {
                    NodeHolder = NodeHolder.next;
                    current_position++;
                }

                if (position_to_Remove > 1)
                {
                    ListNode node_to_Remove = NodeHolder.next;
                    NodeHolder.next = node_to_Remove.next;
                }
                else
                    NewList = head.next;

                return NewList;
            }
        }
    }
}
