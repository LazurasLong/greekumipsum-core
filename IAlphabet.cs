
using System;
using System.Collections.Generic;
using System.Text;
namespace Greekum {
    interface IAlphabet : IProvider {
        string GetAlphabet();
        int GetTotalAlphabetLetterFrequency();
        int[] GetAlphabetLetterFrequencies();
    }
}
