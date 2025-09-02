public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniquenum=new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(uniquenum.Contains(nums[i])){
                return true;
            }
            else{
                uniquenum.Add(nums[i]);
            }
        }
        return false;
    }
}