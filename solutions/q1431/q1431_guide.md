# Guide for Kids With the Greatest Number of Candies

## Takeaways
Nothing really. Just had a syntax issue with `.Length` since they're so minimally different in each language.

## Guide (C#)
1. Create a `List<bool> results` to store the value of comparisons.
2. Create a `max` value that holds the `.Max()` of the `candies` array.
3. In a `for` loop (on `candies.Length`), do the following check:
    - `results.Add(candies[i] + extraCandies >= max`.
    - This checks that the current `candies` index value + the `extraCandies` is less or equal to the `max` candies in the array.
    - If so, it adds a `true` to the list.
    - Else, it adds a `false`.
4. Return `results`.
