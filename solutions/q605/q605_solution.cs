public class Solution {
    public bool CanPlaceFlowers(int[] flowerBed, int n) {

        int flowerCount = 0;

        for(int i=0; i<flowerBed.Length; i++){
            if(flowerBed[i] == 0){
                bool leftPlotValid = (i == 0 || flowerBed[i-1] == 0);
                bool rightPlotValid = (flowerBed.Length - 1 == i || flowerBed[i+1] == 0);
                
                if(leftPlotValid && rightPlotValid) {
                    flowerBed[i] += 1;
                    flowerCount++;
                    i++;
                }
            }
        }

        return flowerCount >= n;
    }
}
