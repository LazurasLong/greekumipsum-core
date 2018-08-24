
using System;
using System.Collections.Generic;
using System.Text;

interface IWordPropertyProvider : IProvider {
    int[] GetWordLengthFrequencies();
    int[] GetWordLengths();
    int GetTotalWordLengthsFrequencies();
}
