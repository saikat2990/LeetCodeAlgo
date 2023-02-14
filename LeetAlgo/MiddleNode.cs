using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetAlgo
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
    public class MiddleNodes
    {
        public ListNode MiddleNode(ListNode head)
        {
            var node = head;
            List<ListNode> list = new List<ListNode>();

            while (node != null)
            {
                list.Add(node);
                node = node.next;
            }

            var middlePoint = (list.Count / 2);
            return list[middlePoint];
        }
    }
}
