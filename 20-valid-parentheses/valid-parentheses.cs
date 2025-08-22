public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> parent=new Dictionary<char,char>{
            {'{','}'},
            {'(',')'},
            {'[',']'}
        };
        Stack<char> matching=new Stack<char>();
        if(s.Length<=1){
            return false;
        }
        foreach(var brace in s){
            if(parent.ContainsKey(brace)){
                matching.Push(brace);
            }
            else if(parent.ContainsValue(brace)){
                if(matching.Count==0||parent[matching.Pop()]!=brace){
                    return false;
                }
            }
        }
        if(matching.Count>0){
            return false;
        }
        return true;
    }
}