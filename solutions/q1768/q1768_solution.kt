class Solution {
    fun mergeAlternately(word1: String, word2: String): String {
        return buildString {
            val minLength = minOf(word1.length, word2.length)

            for (i in 0 until minLength) {
                append(word1[i])
                append(word2[i])
            }

            append(word1.substring(minLength))
            append(word2.substring(minLength))
        }
    }
}
