using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers.LinkedLists
{
    public class CreateLinkedList
    {
        public static ListNode Create(int[] arr)
        {
            if (arr.Length > 0)
            {
                ListNode el = new ListNode(arr[0])
                {
                    next = Create(arr.Skip(1).ToArray())
                };

                return el;
            }

            return null;
        }        
    }
}
