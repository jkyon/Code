using System.Text;

public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int max = 0;
        int startPoint = 0;
        int counter = 0;
        var hashTable = new Dictionary<char, int>();

        for (int i = 0; i < s?.Length; i++)
        {
            if (hashTable.ContainsKey(s[i]))
            {
                max = Math.Max(counter, max);
                i = startPoint;
                startPoint ++;
                counter = 0;
                hashTable.Clear();
                continue;
            }
            hashTable.Add(s[i], i);
            counter ++;
        }

        max = Math.Max(counter, max);
        return max;
    }
}
