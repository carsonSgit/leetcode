# Guide for Max Number of K-Sum Pairs

## Takeaways
No big takeaway, though now I recognize the `two-pointer pattern`.

## Guide (Kotlin)
1. For simplicity, `sort` the `nums` array. This increases the *O Notation* but greatly simplifies the process.
2. Initialize your `left` and `right` pointers as well as the `operations` counter
   - `left = 0`
   - `right = nums.size - 1`
   - `operations = 0`
3. Enter a `while` loop that checks that `left < right` so that we do not pass over a pointer.
4. Declare `variable sum` to be the product of `nums` at the current pointers `left` and `right`.
5. Perform a series of checks:
  - `if sum == k`: *We have found a match*
      - `operations++`
      - `left++`
      - `right--`
  - `if sum > k`: *Array is sorted, so the right pointer value is too high*
      - `right--`
  - `else`: *Sum is less than k, meaning our left pointer value is too small*
      - `left++`
6. Return `operations`
