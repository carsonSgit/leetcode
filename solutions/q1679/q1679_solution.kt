class Solution {
    fun maxOperations(nums: IntArray, k: Int): Int {
        nums.sort()
        var left = 0
        var right = nums.size - 1
        var operations = 0

        while (left < right) {
            val sum = nums[left] + nums[right]
            when {
                sum == k -> {
                    operations++
                    left++
                    right--
                }
                sum > k -> right--
                else -> left++
            }
        }

        return operations
    }
}
