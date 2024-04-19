public class Solution {
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var n = height.Length;
        var i = 0;

        while (i != n - 1)
        {
            var area = (Math.Min(height[i], height[n - 1])) * (n - (i + 1));
            maxArea = Math.Max(maxArea, area);
            if (height[i] > height[n - 1])
            {
                n--;
            }
            else
            {
                i++;
            }
        }
        return maxArea;
    }
}