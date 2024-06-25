# Notes on TwoSum

Important takeaway(s):
1. HashMaps are your friend

Essentially the way to solve TwoSum is to make a HashMap and to rely on methods within the object.

1. Create a `for` loop to search through the length of the `nums` param array.
2. Create an int variable which checks against the `target` param minus the `nums` array at the current index.
3. The variable made can then search through the HashMap made. This is done through `HashMap.containsKey(variable)`.
    - If it returns `true` it means that there is a value in the HashMap that when added with the current value in the nums array iteration will equal the target. We will then return an `int[]` with the index of the HashMap value.
    - If it returns `false` it means that we didn't find that value and will not be returning anything.
4. If we didn't find the number needed in the current loop iteration, we add the nums array's current value and the corresponding index to the HashMap.
5. If ultimately there is no values found we just return a sample `int[]` array.
