
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
    public ListNode MiddleNode(ListNode head)
    {
        var node = head;
        List<ListNode> list = new List<ListNode>();

        while (node!=null)
        {
            list.Add(node);
            node = node.next;
        }

        var middlePoint = (list.Count / 2);
        return list[middlePoint];
    }
}