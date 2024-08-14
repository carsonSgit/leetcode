class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
        max_avg: float = 0
        avg: float = 0
        n:int = len(nums)
        cur_sum: int = 0

        for i in range(k):
            cur_sum += nums[i]

        max_avg = cur_sum / k

        for i in range(k,n):
            cur_sum += nums[i]
            cur_sum -= nums[i-k]

            avg = cur_sum / k
            max_avg = max(max_avg, avg)

        return max_avg

        
