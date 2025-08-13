namespace Problems.LeetCode.LC0002.AddTwoNumbers;
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode();
        ListNode tail = dummyHead;
        int carry = 0;
        while (l1 != null || l2 != null || carry > 0)
        {
            int x = l1 != null ? l1.val : 0;
            int y = l2 != null ? l2.val : 0;
            int sum = x + y + carry;
            carry = sum / 10;
            ListNode temp = new ListNode();
            tail.next = temp;
            temp.val = sum % 10;
            tail = tail.next;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }
        return dummyHead.next;        
    }
}
