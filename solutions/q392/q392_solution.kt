class Solution {
    fun isSubsequence(s: String, t: String): Boolean {
        var sIndex = 0

        for (char in t) {
            if (sIndex < s.length && s[sIndex] == char) {
                sIndex++
            }
        }

        return sIndex == s.length
    }
}
