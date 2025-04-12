namespace Code;

public class TwoSum2Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        var result = new int[2];
        var pointer1 = 0;
        var pointer2 = numbers.Length - 1;

        while (pointer1 <= pointer2)
        {
            var sum = numbers[pointer1] + numbers[pointer2];
            if(sum == target)
            {
                result[0] = pointer1 + 1;
                result[1] = pointer2 + 1;
                break;
            }

            if(sum > target)
            {
                pointer2--;
                continue;
            }
            
            pointer1++;
        }
        
        return result;
    }
}