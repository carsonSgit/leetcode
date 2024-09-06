class Solution {
    fun reverseWords(s: String): String {
        // s.split ( '  ' ) -> get rid of all whitespace
        // map the s split variables to an iterable object, trimming any extra whitespace
        // ensure no empty strings get added to the array 
        var wordArray = s.split(" ").map{it.toString().trim()}.filter{it != ""}

        var answer = ""
        // iterate through the string array created in line one, all the way down to var 1  (decreasing order)
        for(i in wordArray.size - 1 downTo 1) {
            answer += wordArray[i]
            answer += " "
        }

        // add in the ignored first array item
        answer += wordArray[0]
        return answer
    }
}
