public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        var collection = new List<IList<int>>();
        var i = 0;
        var left = i + 1;
        var right = nums.Length - 1;
        var hashSet = new HashSet<string>();
        while (i != left && i != right && left != right)
        {
            if (nums[i] + nums[left] + nums[right] == 0)
            {
                var triplet = $"{nums[i]},{nums[left]},{nums[right]}";
                if(!hashSet.Contains(triplet))
                {
                    collection.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    hashSet.Add(triplet);
                }
                if(right - 1 == left)
                {
                    i++;
                    left = i + 1 >= right ? left :  i + 1;
                    continue;
                }
                right = right - 1 == left ? right : right - 1;
                continue;
            }

            if(left + 1 == right)
            {
                i++;
                left = i + 1 >= right ? left : i + 1;
                continue;
            }

            left = left + 1 == right ? left : left + 1;
            
        }

        return collection;
    }
}