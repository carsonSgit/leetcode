# Guide for Maximum Average Subarray I

## Takeaways
> Sliding window technique.

## Guide (`Python`)
1. Initialize `cur_sum` to be the first `k` elements of the `nums` array. This is the first sliding window instance.
   - Set `max_sum` to be the initial `cur_sum`
2. Within a for loop of the range `k -> n`, start the sliding window calculations.
   - To do so, `cur_sum += nums[i] - nums[i - k]` adds the newest value and removes the oldest one from the current sum.
   - Check if this new `cur_sum` is larger than the current `max_sum`, if so, reassign the `max_sum` to be equal to the newest `cur_sum`, otherwise, don't...
3. Return the `max_sum` divided by the `k` element.
