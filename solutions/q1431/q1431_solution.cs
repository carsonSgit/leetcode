public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> results = new List<bool>();

        int max = candies.Max();

        for(int i=0; i< candies.Length; i++){
            results.Add(candies[i] + extraCandies >= max);
        }

        return results;
    }
}
