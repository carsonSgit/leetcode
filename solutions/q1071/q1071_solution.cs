public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // verifies that str1 + str2 are pallindrome-esque
        if (!(str1 + str2).Equals(str2 + str1)) {
            return "";
        }
        
        /*
            While loop condition: strings are not equal

            If statement condition: if str1 is longer than str2, shrink str1 by the length of str2
            Else condition: if str2 is longer than str1, shrink str2 by the length of str1
            When str1 and str2 become equal, the loop will exit
        */
        while (!str1.Equals(str2)) {
            if (str1.Length > str2.Length) {
                str1 = str1.Substring(str2.Length);
            } else {
                str2 = str2.Substring(str1.Length);
            }
        }
        
        return str1;
    }
}
