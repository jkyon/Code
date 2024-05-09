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

    public int ClimbStairsImproved(int n) 
    {
        var pointer1 = 1;
        var pointer2 = 1;
        var i = 0;
        while(i < (n - 1))
        {
            var curr = pointer1 + pointer2;
            pointer2 = pointer1;
            pointer1 = curr;
            i++;
        }

        return pointer1;
    }


}