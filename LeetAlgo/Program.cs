



using LeetAlgo;

public class Solution
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
        var temp = head;
        while (true)
        {
            if (temp.next == null)
            {
                temp.next = new ListNode(node.val,null);
                break;
            }

            temp = temp.next;
            
        }
        return head;
    }

    public static ListNode ReverseKGroup(ListNode head, int k)
    {
        List<ListNode> listNode = new List<ListNode>();
        var remain = new ListNode();
        var tempGroup = k;
        while (head!=null)
        {
            var newGroupHead = new ListNode();
            var temp = head;
            while (tempGroup>0)
            {
                newGroupHead = AddNode(head, newGroupHead);
                temp.next = head.next;
                tempGroup--;
                if (temp.next == null)
                {
                    remain = newGroupHead;
                    
                    break;
                }

                
                head = head.next;
                temp = temp.next;
                
            }
            
            tempGroup = k;
            listNode.Add(newGroupHead);
            if (head.next == null)
            {
                remain = new ListNode(head.val,null);

                break;
            }
        }
        listNode.Add(remain);
        var answer = new ListNode();
        var final = answer;
        for (int i = 0; i < listNode.Count; i++)
        {
            
            listNode[i] = ReverseList(listNode[i]);
            var check = listNode[i];
            while (check.next!=null && check.next.next != null)
            {
                check = check.next;
            }
            check.next=null;
            var newCheck = listNode[i];
            while (newCheck != null)
            {
                Console.WriteLine(newCheck.val);
                answer.next = newCheck;
                answer = answer.next;
                newCheck = newCheck.next;
            }
        }

        while (final != null)
        {
            Console.WriteLine(final.val);
            final = final.next;
        }

        return head;
    }

    public static void Main(string[] args)
    {
        var nodes = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
        ReverseKGroup(nodes, 2);
    }

}
