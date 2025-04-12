namespace Code;

public class ThreeSumSolution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var pointer1 = 1;

        for(var x = 0; x < pointer1; x++)
        {
            if(x > 0 && nums[x] == nums[x - 1]) 
            {
                continue;
            }

            pointer1 = x + 1;
            var pointer2 = nums.Length - 1;
            
            while (pointer1 < pointer2)
            {
                var sum = nums[x] + nums[pointer1] + nums[pointer2];
                if(sum == 0)
                {
                    result.Add(new List<int> { nums[x], nums[pointer1], nums[pointer2] });
                    pointer1++;
                    while(nums[pointer1] == nums[pointer1 - 1] && pointer1 < pointer2)
                    {
                        pointer1++;
                    }
                    continue;
                }

                if(sum > 0)
                {
                    pointer2--;
                    continue;
                }
                pointer1++;
            }

        }
        
        return result;
    }
}