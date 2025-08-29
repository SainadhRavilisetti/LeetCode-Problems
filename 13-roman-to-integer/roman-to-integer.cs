public class Solution {
    public int RomanToInt(string s) {
        int num=0;
        int num1=0;
        for(int i=0;i<s.Length;i++){
            if(i>0){
                if(romanresult(s[i-1])<romanresult(s[i])){
                    num-=romanresult(s[i-1]);
                    num +=(romanresult(s[i]))-(romanresult(s[i-1]));
                }
                else{
                    num+=romanresult(s[i]);
                }
            }
            else{
                num+=romanresult(s[i]);
            } 
            Console.WriteLine(num);
        }
         return num;
    }
    public int romanresult(char x){
        int num1=0;
           switch(x){
                case 'I':
                num1=1;
                break;
                case 'V':
                num1=5;
                break;
                case 'X':
                num1=10;
                break;
                case 'L':
                num1=50;
                break;
                case 'C':
                num1=100;
                break;
                case 'D':
                num1=500;
                break;
                case 'M':
                num1=1000;
                break;
            }
            return num1;
    }
    
}