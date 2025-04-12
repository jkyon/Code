namespace Code;

public class MaxSubArraySolution 
{
    public int MaxSubArray(int[] nums) 
    {
        var max = nums[0];
        var sumAcum = 0;

        foreach(var num in nums)
        {
            if(sumAcum < 0)
            {
                sumAcum = 0;
            }
            sumAcum += num;
            max = Math.Max(sumAcum, max);
        }

        return max;
    }
}