# Guide for Merge Strings Alternately

## Takeaways
C# StringBuilders. I always forget they exist.

## Guide (C#)
1. Initialize a `StringBuilder`. This is the word that will be created using the two `word params`.
2. Assign `3 length variables`. These are the lengths of each word & the largest length.
3. In a `for` loop that has the `constraint` of the `max length`, there are two `if` conditions.
    - The `if`s check that the index of iteration from the current loop is not greater than the length of the word.
    - If the index is not greater, we `append` it to the `StringBuilder`.
