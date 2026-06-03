public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] ans = new int[k];
        int i = 0;
        Dictionary<int,int> most = new Dictionary<int,int>();
        foreach(int n in nums){
            if(!most.ContainsKey(n)){
                most.Add(n,0);
            }
            most[n]++;
        }
        var sorted = most.OrderByDescending(m => m.Value);

        foreach(var kvp in sorted){
            if(i < k){
                ans[i] = kvp.Key;
                i++;
            }else{
                break;
            }
        }

        return ans;
    }
}
