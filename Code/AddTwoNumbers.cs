namespace Code;


public class TwoNumbers 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var pointer1 = l1;
        var pointer2 = l2;

        var resultHead = new ListNode(-1);
        var resultPointer = resultHead;
        var leftOver = 0;

        while(pointer1 != null || pointer2 != null)
        {

            var value1 = pointer1 != null ? pointer1.val : 0;
            var value2 = pointer2 != null ? pointer2.val : 0;
            var valueRes = (value1 + value2 + leftOver).ToString();
            var res = valueRes.Length > 1 ? Convert.ToInt32(valueRes.Substring(1, 1)) : Convert.ToInt32(valueRes);
            leftOver = valueRes.Length > 1 ? Convert.ToInt32(valueRes.Substring(0, 1)) : 0;
            resultPointer = BuildResult(res, resultPointer);

            pointer1 = pointer1?.next;
            pointer2 = pointer2?.next;
        
        }

        if(leftOver > 0) 
        {
            BuildResult(leftOver, resultPointer);
        }

        return resultHead;
    }

    private ListNode BuildResult(int value, ListNode head)
    {
        if(head.val < 0)
        {
            head.val = value;
            return head;
        }
        var newHeadPointer = new ListNode(value);
        head.next = newHeadPointer;
        return newHeadPointer;
    }
    
    public class ListNode {
    
        public int val;
    
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) {
            this.val = val;
            this.next = next; }
    }

}

