using System.Text;

public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int max = 0;
        int startPoint = 0;
        int counter = 0;
        var sb = new StringBuilder();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            sb.Append(s[i]);
            counter++;
            if(i == s.Length - 1)
            {
                max = counter > max ? counter : max;
                break;
            }

            if (sb.ToString().Contains(s[i + 1].ToString()))
            {
                max = counter > max ? counter : max;
                i = startPoint;
                startPoint++;
                counter = 0;
                sb.Clear();
                continue;
            }
        }

        return max;
    }
}
