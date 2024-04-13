using System.Text;

public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int max = 0;
        int startPoint = 0;
        int counter = 0;
        var hashTable = new Dictionary<char, int>();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            hashTable.Add(s[i], i);
            counter ++;

            if(i == s.Length - 1)
            {
                break;
            }

            if (!hashTable.ContainsKey(s[i + 1]))
            {
                max = Math.Max(counter, max);
                i = startPoint;
                startPoint ++;
                counter = 0;
                hashTable.Clear();
            }
        }

        max = Math.Max(counter, max);
        return max;
    }
}
