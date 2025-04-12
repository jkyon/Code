namespace Code
{
    public class ContainsDupSolution 
    {
        public bool ContainsDuplicate(int[] nums) 
        {
            var hashSet = new HashSet<int>();

            foreach (var num in nums)
            {
                if(hashSet.Contains(num))
                {
                    return true;
                }
                hashSet.Add(num);
            }     

            return false;
        }
    }
}