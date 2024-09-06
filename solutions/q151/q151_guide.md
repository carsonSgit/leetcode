# Guide for Reverse Words in a String

## Takeaways
> I love the short form that kotlin offers. StringBuilders are very easy to forget.

## Guide (`Kotlin`)
1. Create an `array` based off of the `s` parameter value.
   - Split at any white spaces (" ").
   - Map the array to convert all iterable values to strings and trim the excess white space.
   - Filter out any empty strings.
2. Declare your default answer variable to be an empty string.
3. Enter a for loop with the following condition: Iterate through the string array created in line one, all the way down to var 1 (decreasing order)
   - Append each iteration of the `wordArray[i]` to your `answer` string variable.
   - Append a whitespace to the answer variable.
4. Before returning your `answer`, add the first ignored array item
   - We use a decreasing order and stop at 1 to avoid the extra operation of adding a whitespace to the end of the answer.
5. Return your `answer` string.
