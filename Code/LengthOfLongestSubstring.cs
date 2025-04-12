namespace Code;

public class LongestSubstring
{
    public int LengthOfLongestSubstring(string s) 
    {
        int startPoint = 0;
        int counter = 0;
        var hashTable = new Dictionary<char, int>();

        for (int i = 0; i < s?.Length; i++)
        {
            if (!hashTable.ContainsKey(s[i]))
            {
                hashTable.Add(s[i], i);
                counter = Math.Max(counter, i + 1 - startPoint);
                continue;
            }
            startPoint = Math.Max(hashTable[s[i]] + 1, startPoint);
            counter = Math.Max(counter, i +  1 - startPoint);
            hashTable[s[i]] = i;
        }

        return counter;
    }
}