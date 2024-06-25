class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        if len(s) == 0:
            return True
        if len(t) == 0:
            return False

        sIndex, tIndex = 0, 0

        while tIndex < len(t) and sIndex < len(s):
            if(s[sIndex] == t[tIndex]):
                sIndex += 1
            tIndex += 1
        
        return sIndex == len(s)
