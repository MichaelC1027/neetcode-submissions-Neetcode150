public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0){
            return false;
        }
        Dictionary<int,int> numbers = new Dictionary<int,int> {};
        foreach(var n in nums){
            if(!numbers.ContainsKey(n)){
                numbers.Add(n,0);
            }
            numbers[n] += 1;
        }

        return numbers.Values.Max() > 1;
    }
}