# Guide for Greatest Common Divisor of Strings

## Takeaways
Questions can be misleading/not clearly worded. Read the discuss section and look at solutions provided by the community to understand.

## Guide (C#)
1. First we have to verify our edge case, so we check that the strings follow a pattern.
  - To do so, we concat `str1` + `str2` and compare it to `str2` + `str1`.
  - If these are not `equal`, then they do not have a GCD.
2. Create a `while` loop that iterates as long as `str1` is not equal to `str2`.
3. Within the `while` loop, check `if` the `length` of `str1` is less than that of `str2`.
  - If it is less, then we reassign `str1` to be a `substring` of `str2`'s `length`.
  - If not, `str2` becomes a `substring` of `str1`'s `length`.
4. Return either string.
