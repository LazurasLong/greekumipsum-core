
using System;
using System.Collections.Generic;
using System.Text;

namespace Greekum {
    interface IWordPropertyProvider : IProvider {
        int[] GetWordLengthFrequencies();
        int[] GetWordLengths();
        int GetTotalWordLengthsFrequencies();
    }
}
