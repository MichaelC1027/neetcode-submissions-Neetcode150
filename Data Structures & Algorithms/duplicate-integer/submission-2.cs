public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> ans = new HashSet<int>();
        foreach(var i in nums){
            if(!ans.Contains(i)){
                ans.Add(i);
            } else {
                return true;
            }
        }
        return false;
    }
}