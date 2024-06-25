# Guide for Container With Most Water

## Takeaways
It's important to run through the question beforehand to deeply understand what the parameters for success are.

## Guide (Python)
1. Initializing variables (`result`, `left`, `right`).
2. Begin searching using a `while` loop that ensures we do not start calculating backwards (`while left < right`).
3. Then calculate the area of the current "container" which is the distance between our `left and right indices` * `minimum height` of the two indices.
4. Assign the `result` to be the highest of the current result (max area) and the current area.
5. If the height of our left index is less than that of the right, we move forward by one on the left.
6. Alternatively, if our right index is less than the left, we bring the right closer inwards (subtract by one)
7. Return result.
