public class Subsets1 
{
    List<IList<int>> solution = new List<IList<int>>();

    public IList<IList<int>> Subsets(int[] nums)
    {
        var subset = new List<int>();
        solution.Add(subset);
        AddSubset(nums, subset, 0, nums.Length - 1);
		
        return solution;
    }

    private void AddSubset(int[] nums, List<int> currentSol, int index, int length)
    {

        if (index > length)
        {
            return;
        }
		
        var newSubset = new List<int>();
        newSubset.AddRange(currentSol);
        newSubset.Add(nums[index]);
        solution.Add(newSubset);

        //left
        AddSubset(nums, newSubset, index + 1, length);

        //right
        AddSubset(nums, currentSol, index + 1, length);
    }
}