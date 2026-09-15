public class Solution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, @"[\?! -,.:]", "").ToLower();
        if(s.Length <= 1){return true;}
        int len = s.Length;
        int j = len-1;

        for(int i = 0; i <= len / 2; i++){
            if(s[i] != s[j]){
                return false;
            }
            j--;
        }

        return true;
    }
}
