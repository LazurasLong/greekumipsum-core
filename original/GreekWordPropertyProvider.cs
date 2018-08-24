
using System;
using System.Collections.Generic;
using System.Text;

class GreekWordPropertyProvider : IWordPropertyProvider {
    public int[] GetWordLengthFrequencies() {
        return new int[] { 0, 0, 5, 3, 5, 16, 35, 60, 89, 114, 132, 136, 126, 103, 73, 48, 29, 16, 9, 4, 2, 1, 0, 0, 0, 0 };
    }
    public int[] GetWordLengths() {
        return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
    }
    public int GetTotalWordLengthsFrequencies() {
        return 1005;
    }
}
