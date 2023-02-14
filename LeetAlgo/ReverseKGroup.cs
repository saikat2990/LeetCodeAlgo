using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetAlgo
{
    internal class ReverseKGroup
    {

        public static ListNode ReverseList(ListNode head)
        {
            ListNode resNode = null;
            while (head != null)
            {
                resNode = new ListNode(head.val, resNode);
                head = head.next;
            }


            return resNode;
        }

        private static ListNode AddNode(ListNode node, ListNode head)
        {
            if (node == null)
            {
                return head;
            }

            var temp = head;
            while (true)
            {
                if (temp.next == null)
                {
                    temp.next = new ListNode(node.val, null);
                    break;
                }

                temp = temp.next;

            }
            return head;
        }

        public static ListNode ReverseKGroups(ListNode head, int k)
        {
            List<ListNode> listNode = new List<ListNode>();
            var remain = new ListNode();
            var tempGroup = k;
            while (head != null)
            {
                var newGroupHead = new ListNode();
                var temp = head;
                var iteration = 0;
                while (tempGroup > 0 && temp != null && head != null)
                {
                    newGroupHead = AddNode(head, newGroupHead);
                    if (iteration == 0)
                    {
                        newGroupHead = newGroupHead.next;
                    }

                    iteration++;
                    temp.next = head.next;
                    tempGroup--;
                    head = head.next;
                    temp = temp.next;

                }

                tempGroup = k;
                listNode.Add(newGroupHead);
                remain = null;
                if (head != null && head.next == null)
                {
                    remain = new ListNode(head.val, null);

                    break;
                }
            }

            if (remain != null)
            {
                listNode.Add(remain);
            }


            var answer = new ListNode();
            var final = answer;
            for (int i = 0; i < listNode.Count; i++)
            {
                var valNumberCheck = 0;
                var newCheck1 = listNode[i];
                while (newCheck1 != null)
                {
                    valNumberCheck++;
                    newCheck1 = newCheck1.next;
                }
                if (valNumberCheck == k)
                    listNode[i] = ReverseList(listNode[i]);

                var newCheck = listNode[i];
                while (newCheck != null)
                {
                    //Console.WriteLine(newCheck.val);
                    answer.next = newCheck;
                    answer = answer.next;
                    newCheck = newCheck.next;
                }
            }

            final = final.next;
            while (final != null)
            {
                Console.WriteLine(final.val);
                final = final.next;
            }

            return final;
        }

    }
}
