namespace Code;

public class ThreeSumCloset 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        var closest = 100001;
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            var pointer1 = i + 1;
            var pointer2 = nums.Length - 1;
            while (pointer1 < pointer2)
            {
                var sum = nums[i] + nums[pointer1] + nums[pointer2];
                if (sum == target)
                {
                    return sum;
                }

                if (Math.Abs(target - sum) <  Math.Abs(target - closest))
                {
                    closest = sum;
                }
                
                if(sum < target)
                {
                    pointer1++;
                    continue;
                }

                pointer2--;
            }	
        }
        return closest;
    }
}