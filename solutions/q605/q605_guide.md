# Guide for Can Place Flowers

## Takeaways
> The `greedy algorithm` is really helpful.

## Guide (`C#`)
1. Initialize a `counter` for the flowers you will be adding.
2. Begin a `for` loop that iterates through the `flowerBed` array.
3. If the current index of the `flowerBed` is empty (`0`), we do the following.
    - Declare a `bool` value `leftPlotValid` that checks the following:
      - `i == 0`, checking that we are in the first index / the leftmost slot of the array (to avoid going out of bounds). 
      - **OR (||)** `flowerBed[i-1] == 0`, checking that the slot to the left of the current index is empty.
    - Declare a `bool` value `rightPlotValid` that checks the following:
      - `flowerBed.Length - 1 == i`, checking that we are not at the end of the array (to avoid going out of bounds).
      - **OR (||)** `flowerBed[i+1] == 0`, checking that the slot to the right of the current index is empty.
    - Following this, we check that these are both true, if so, we do the following:
      - `flowerBed[i] += 1` to add a new flower to the array.
      - `flowerCount++` (the intialized counter in step `1.`)
      - `i++` to go to the next array slot.
4. return a boolean comparison `counter >= n`.
