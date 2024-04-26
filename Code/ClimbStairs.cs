public class Solution 
{
    public int ClimbStairs(int n) 
    {
        var cache = new Dictionary<int, int> ();
        var result = Steps(n + 1, cache);
        return result;
    }

    private int Steps(int i, Dictionary<int, int> cache)
    {
        if(i == 0)
        {
            return 0;
        }

        if(i == 1)
        {
            return 1;
        }

        if(!cache.ContainsKey(i))
        {
            cache.Add(i, Steps(i - 1, cache) + Steps(i - 2, cache));
        }

        return cache[i];
    }
}