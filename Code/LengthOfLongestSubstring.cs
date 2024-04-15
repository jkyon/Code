using System.Text;

public class Solution
{
    public int LengthOfLongestSubstring(string s) 
    {
        int startPoint = 0;
        int counter = 0;
        var hashTable = new Dictionary<char, int>();

        for (int i = 0; i < s?.Length; i++)
        {
            if (hashTable.ContainsKey(s[i]))
            {
                startPoint++;
                hashTable[s[i]] = i;
                counter = Math.Max(counter, i - startPoint +  1);
                continue;
            }
            hashTable.Add(s[i], i);
            counter = Math.Max(counter, i - startPoint +  1);
        }

        return counter;
    }
}
