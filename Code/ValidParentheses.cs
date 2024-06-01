public class Solution {
    public bool IsValid(string s) 
    {
        var dictionary = new Dictionary<char, char> {
            {'{', '}'},
            {'[', ']'},
            {'(', ')'},
        };
        var stack = new Stack<char>();
        
        foreach(var bracket in s)
        {
            if(dictionary.ContainsKey(bracket))
            {
                stack.Push(bracket);
                continue;
            }

            if(!stack.TryPeek(out var peekItem))
            {
                return false;
            }

            if(dictionary.ContainsKey(peekItem) && dictionary[peekItem] == bracket)
            {
                stack.Pop();
                continue;
            }
            return false;
        }
        

        return stack.Count <= 0;
    }
}