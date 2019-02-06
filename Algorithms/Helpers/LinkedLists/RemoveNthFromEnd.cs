using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers.LinkedLists
{
    public class RemoveNthFromEnd
    {
        public static ListNode Remove(ListNode head, int n)
        {
            // Create a dummy node
            var dummy = new ListNode(0);
            int length = 0;
            // Put the dummy node at the beginning of the linked list
            dummy.next = head;
            // Calculate the length
            var first = head;
            while (first != null)
            {
                length++;
                // Traverse through nodes
                first = first.next;
            }

            length -= n;
            first = dummy;
            while (length > 0)
            {
                length--;
                first = first.next;
            }

            first.next = first.next.next;
            return dummy.next;
        }
    }
}
