public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        foreach (var c in s)
        { 
            if (sDict.ContainsKey(c))
            {
                sDict[c]++;
            }
            else
            {
                sDict.Add(c, 1);
            }
        }
        
        foreach (var c in t)
        {
            if (tDict.ContainsKey(c))
            {
                tDict[c]++;
            }
            else
            {
                tDict.Add(c, 1);
            }
        }
        
        foreach(var kvp in sDict){
            if (!tDict.ContainsKey(kvp.Key))
            {
                return false;
            }
            if (tDict[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }
        return true;
    }
}
