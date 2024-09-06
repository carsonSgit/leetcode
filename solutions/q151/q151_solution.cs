public class Solution {
    public string ReverseWords(string s) {
        List<string> words = s.Split(' ').ToList();

        words.Reverse();
        StringBuilder sb = new StringBuilder();
        foreach(var w in words){
            sb.Append(w + " ");
        }

        StringBuilder test = new StringBuilder();
        for(int i=0; i< sb.Length -1; i++){
            char currentChar = sb[i];
            if(char.IsWhiteSpace(currentChar)){
                if (i == sb.Length - 1 || !char.IsWhiteSpace(sb[i + 1])) {
                    test.Append(currentChar);
                }
            }
            else {
                test.Append(currentChar);
            }
        }

        return test.ToString().Trim();
    }
}
