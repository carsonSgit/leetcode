# Guide for Reverse Vowels of a String

## Takeaways
> .join is key to convert lists to strings.

## Guide (`Kotlin`)
1. Initialize the `set` of `vowels` (both in lowercase and uppercase).
2. Convert the string param `s` to a `MutableList` (for a fun solution).
3. Initialize your pointers (starting point & last point of the param).
4. Enter a `while` loop that runs off the condition that `i < j`.
   - **IF** `chars[i] !in vowels` (A.K.A., if the current character of index `i` is not in the `vowels` set), increment `i`.
   - **ELSE IF** `chars[j] !in vowels` (A.K.A., if the current character of index `j` is not in the `vowels` set), decrement `j`.
   - **ELSE**, using the `import java.util.Collections`, since we converted the string param `s` to a `MutableList`, we can use the `Collections.swap()` method rather than manually swapping.
     - Increment `i` and decrement `j`.
5. Return `MutableList.joinToString("")`.
