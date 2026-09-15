public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ans = 0;
        int max = 0;
        int temp = 0;
        int j = 0;
        foreach(var i in nums){
            Console.WriteLine("we are in index " + j);
            if(i != 1){
                Console.WriteLine("inside the if != statement");

                if(temp > ans){
                    ans = temp;
                }
                temp = 0;
            }
            else{
                temp++;
            }
            j++;
            Console.WriteLine();
        }
        if(temp > ans){
            ans = temp;
        }
        return ans;
    }
}