public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;

        int sIndex = 0, tIndex = 0;

        while (tIndex < t.Length && sIndex < s.Length) {
            if (s[sIndex] == t[tIndex]) {
                sIndex++;
            }
            tIndex++;
        }

        return sIndex == s.Length;
    }
}
