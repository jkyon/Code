public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        var resultSet = new int[2];

        resultSet[0] = FindOccurence(nums, target,true);

        resultSet[1] = FindOccurence(nums, target,false);

        return resultSet;
    }

    private int FindOccurence(int[] nums, int target, bool findOnLeft)
    {
        var pLeft = 0;
        var pRight = nums.Length - 1;
        var middle = 0;
        var result = -1;

        while (pLeft <= pRight)
        {
            middle = (pLeft + pRight) / 2;

            if (nums[middle] > target)
            {
                pRight = middle - 1;
            }
            else if (nums[middle] < target)
            {
                pLeft = middle + 1;
            }
            else
            {
                result = middle;
                if(findOnLeft)
                {
                    pRight = middle - 1;
                }
                else
                {
                    pLeft = middle + 1;
                }
            }
        }

        return result;
    }
}