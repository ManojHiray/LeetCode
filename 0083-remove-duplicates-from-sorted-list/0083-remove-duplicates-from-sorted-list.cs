/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == null || head.next == null) return head;
        ListNode prev = head;
        ListNode temp = prev.next;
        
        while(temp!=null)
        {
            if(temp.val == prev.val)
            {
                temp = temp.next;
                continue;
            }
            prev.next = temp;
            prev = temp;
            temp = temp.next;
        }
        prev.next=null;
        return head;
        
        /*
         if (head == null || head.next == null) return head;
        
        ListNode temp = head;
        while(temp != null && temp.next != null)
        {
            if (temp.val == temp.next.val)
            {
                temp.next = temp.next.next;   
            }
            else
            {
                temp = temp.next;
            }
        }
        return head;
        */
    }
}