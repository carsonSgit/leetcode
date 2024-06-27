public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder word3 = new StringBuilder();
        int length1 = word1.Length;
        int length2 = word2.Length;
        int maxLength = Math.Max(length1, length2);

        for (int i = 0; i < maxLength; i++) {
            if (i < length1)
                word3.Append(word1[i]);
            if (i < length2)
                word3.Append(word2[i]);
        }

        return word3.ToString();
    }
}
