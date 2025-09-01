public class Solution {
    public int MajorityElement(int[] nums) {
         int candidate = 0, count = 0;

        foreach (int num in nums) {
            if (count == 0) {
                // Console.WriteLine("count:"+count);
                candidate = num; // Assign new candidate
            }

            count += (num == candidate) ? 1 : -1;
            // Console.WriteLine("count:"+count);
        }

        return candidate;
    }
}