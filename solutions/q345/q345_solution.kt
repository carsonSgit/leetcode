import java.util.Collections

class Solution {
    fun reverseVowels(s: String): String {
        val vowels = setOf('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O','U')
        val chars = s.toMutableList()

        var i = 0
        var j = chars.size - 1

        while( i < j ) {
            if(chars[i] !in vowels)
                i++
            else if(chars[j] !in vowels)
                j--
            else{
                Collections.swap(chars,i,j)
                i++
                j--
            }
        }

        return chars.joinToString("")
    }
}
