/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {

        if(list1 == null && list2 == null)
        {
            return null;
        }
        var pointer1 = list1;
        var pointer2 = list2;
        
        ListNode resultList = new ListNode(-2000);
        var resultPointer = resultList;

        while (pointer1 != null && pointer2 != null)
        {
            if(pointer1?.val <= pointer2?.val)
            {
                resultPointer.next = new ListNode(pointer1.val);
                resultPointer = resultPointer.next;
                pointer1 = pointer1.next;
                continue;
            }
            
            resultPointer.next = new ListNode(pointer2.val);
            resultPointer = resultPointer.next;
            pointer2 = pointer2.next;
        }

        if(pointer1 == null)
        {
            resultPointer.next = pointer2;
        }

        if(pointer2 == null)
        {
            resultPointer.next = pointer1;
        }

        return resultList.next;
    }
}