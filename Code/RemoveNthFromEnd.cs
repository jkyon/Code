namespace Code;

public class RemoveNFromEnd {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        var pointer1 = head;
        var pointer2 = head;
        var count = 0;

        while (pointer2?.next != null)
        {
            if (count != n)
            {
                pointer2 = pointer2?.next;
                count++;
                continue;
            }

            pointer2 = pointer2?.next;
            pointer1 = pointer1?.next;
        }

        if(count == n - 1)
        {
            pointer1 = pointer1?.next;
            return pointer1;
        }

        pointer1.next = pointer1?.next?.next;
        return head;
    }
    
    
    public class ListNode 
    {
    
        public int val;
    
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }

}