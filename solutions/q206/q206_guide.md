# Guide for Reverse Linked List

## Takeaways
> Reversing Linked Lists is super cool.

## Guide (`C++`)
1. *Initialize & Assign* three `ListNode*` objects:
   - `*cur = head`
   - `*prev = NULL`
   - `*next = NULL`
2. Enter a `while` loop conditional on `cur != NULL`
    1. `next = cur->next`
       - This shifts the `next` cursor to the `cur`'s *pointer* to the `next` *ListNode*
    2. `cur->next = prev`
       - This shifts the `cur`'s current pointer to the `prev` *ListNode*.
    3. `prev = cur`
       - This swaps the `prev`'s assigned value to be `cur`.
    4. `cur = next`
       - This swaps the `cur`'s assigned variable to be `next`.
3. Return `prev`.
   
```c++
/* Visual Representation in accordance with the step by step shown above */
// 1.
prev: NULL
cur:  1 -> 2 -> 3 -> 4 -> NULL
next: NULL
// 2.1.
prev: NULL
cur:  1 -> 2 -> 3 -> 4 -> NULL
next: 2 -> 3 -> 4 -> NULL
// 2.2.
prev: NULL
cur:  1 -> NULL
next: 2 -> 3 -> 4 -> NULL
// 2.3.
prev: 1 -> NULL
cur:  1 -> NULL
next: 2 -> 3 -> 4 -> NULL
// 2.4.
prev: 1 -> NULL
cur:  2 -> 3 -> 4 -> NULL
next: 2 -> 3 -> 4 -> NULL
// 3. Once fully a Reversed List:
prev: 4 -> 3 -> 2 -> 1 -> NULL
return prev;
```
