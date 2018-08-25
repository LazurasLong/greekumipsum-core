
using System;
using System.Collections.Generic;
using System.Text;

class CleanGreekWordPropertyProvider : IWordPropertyProvider {
    int[] lengthFrequencies = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    
    public int[] GetWordLengthFrequencies() {
        return lengthFrequencies;
    }
    public int[] GetWordLengths() {
        return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
    }
    public int GetTotalWordLengthsFrequencies() {
        int total = 0;
        for(int i = 0; i < lengthFrequencies.Length; i++) {
            total += lengthFrequencies[i];
        }
        return total;
    }
}
