/*
  This version `q345_solution_concise.kt` is the one I prefer because it's more distinctly using the power of Kotlin.
  For this, I tried to use Kotlins short-form conditions to the best of my ability, I think it looks really nice.
 */

import java.util.Collections

class Solution {
    fun reverseVowels(s: String): String {
        val vowels = "aeiouAEIOU".toSet()
        val chars = s.toCharArray().toMutableList()

        var i = 0
        var j = chars.size - 1

        while (i < j) {
            when {
                chars[i] !in vowels -> i++
                chars[j] !in vowels -> j--
                else -> {
                    Collections.swap(chars, i, j)
                    i++
                    j--
                }
            }
        }

        return chars.joinToString("")
    }
}
