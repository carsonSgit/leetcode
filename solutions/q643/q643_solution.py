class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
        n = len(nums)
        cur_sum = sum(nums[:k])  
        max_sum = cur_sum  

        for i in range(k, n):
            cur_sum += nums[i] - nums[i - k]  
            max_sum = max(max_sum, cur_sum)

        return max_sum / k
