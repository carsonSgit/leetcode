# Guide for Is Subsequence

## Takeaways

Not much to takeaway here, pretty simple problem. the param safeties were cool to do and done differently than what I usually do.

## Guide (C#)

1. Checking the input params:
   - If the length of `s` is zero, we can return `true` because `string s` cannot exist in `string t` if there is no `string s`.
   - Alternitavely, if the length of `t` is zero, we return `false` as `string s` cannot exist in an empty string.
2. Declare two `index` variables that will be used for the search.
3. Initialize a `while` loop that checks that we have not passed the lengths of the params with our declared indicies.
4. Within the while loop, we check `if` the current char of the `s` param (`s[sIndex]` is equal to the current char of the `t` param (`t[tIndex]`).
    - If this returns true, we increment the `sIndex` since we can cross it off the list as it as found already.
5. After the `if`, we increment the `tIndex` to go onto the next char in the `t` string.
6. Once we have fully searched through the `s & t` strings, we can return `sIndex == s.Length`.
    - We return `sIndex == s.Length` because of the sIndex increment in the success of the if statement. If we went through the while loop and found 3 chars from the `s` param in the `t` param and our `s` is only 3 chars long, we have found all characters sequentially in the `t` string.

