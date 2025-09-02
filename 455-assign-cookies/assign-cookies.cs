public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
       Array.Sort(g);
        Array.Sort(s);
        int i=0,j=0,result=0;
        while(i<g.Length && j<s.Length){
            // Console.WriteLine("i"+g[i]+"   "+"j"+s[j]);
            if(g[i]<=s[j]){
                result++;
                i++;
            }
                j++;
        }
        return result;
    }
}