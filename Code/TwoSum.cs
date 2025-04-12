namespace Code;

public class TwoSumSolution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var result = new int[2];
        var dictionary = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            if(dictionary.ContainsKey(nums[i]))
            {
                result[0] = dictionary[nums[i]];
                result[1] = i;
                break;
            }

            dictionary.TryAdd(target - nums[i], i);
        }


        return result;
    }
}