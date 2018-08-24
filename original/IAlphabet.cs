
using System;
using System.Collections.Generic;
using System.Text;

interface IAlphabet : IProvider {
    string GetAlphabet();
    int GetTotalAlphabetLetterFrequency();
    int[] GetAlphabetLetterFrequencies();
}
