using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetAlgo
{


    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode resNode = null;
            while (head != null)
            {
                resNode = new ListNode(head.val, resNode);
                head = head.next;
            }


            return resNode;
        }
    }
}
