public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        var left = 0;
        var right = nums.Length - 1;
        int result;
        
        if (nums[right] > nums[left] || nums[right] == nums[left])
        {
            result = Array.BinarySearch(nums, left, right+1, target);
            return result >= 0 ? result : -1;
        }

        var pivot = FindPivot(nums);

        if (nums[pivot] == target)
        {
            return pivot;
        }

        if (target < nums[left])
        {
            left = pivot + 1;
            result = Array.BinarySearch(nums, left, Math.Abs(right - left) + 1, target);
            return result >= 0 ? result : -1;
        }
        else
        {

            right = pivot;
            result = Array.BinarySearch(nums, left, right + 1, target);
            return result >= 0 ? result : -1;
        }
    }

    int FindPivot(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var middle = (left + right) / 2;
        while (nums[middle + 1] > nums[middle])
        {
            if(nums[right] < nums[middle])
            {
                left = middle;
                middle = (left + right) / 2;
                continue;
            }
            
            if(nums[right] > nums[middle])
            {
                right = middle;
                middle = (left + right) / 2;
            }
        }
        
        return middle;
    }

}