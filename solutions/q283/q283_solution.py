class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        insert_index = 0
        for current_index in range(len(nums)):
            if nums[current_index] != 0:
                nums[insert_index] = nums[current_index]
                insert_index += 1
        
        for i in range(insert_index, len(nums)):
            nums[i] = 0
