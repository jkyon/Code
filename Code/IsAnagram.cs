public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        var dictionary = new Dictionary<char,(int sVal, int tVal)>();

        for(var i = 0; i < s.Length; i++)
        {
            if(dictionary.ContainsKey(s[i]))
            {
                var tupVal = dictionary[s[i]];
                tupVal.sVal += 1;
                dictionary[s[i]] = tupVal;
            }
            else
            {
                dictionary.Add(s[i], (1, 0));
            }

            if(dictionary.ContainsKey(t[i]))
            {
                var tupVal = dictionary[t[i]];
                tupVal.tVal += 1;
                dictionary[t[i]] = tupVal;
            }
            else
            {
                dictionary.Add(t[i], (0,1));
            }
        }

        return dictionary.All(item => item.Value.tVal == item.Value.sVal);
    }
}