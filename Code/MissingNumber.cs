public class Solution {
    public int MissingNumber(int[] nums) {
        var total = 0;
        var subTotal = 0;
        
        for(var i = 1; i <= nums.Length; i++)
        {
            total += i;
            subTotal += nums[i - 1];
            
        }
        return total - subTotal;
    }
}