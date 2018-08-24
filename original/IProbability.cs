
using System;
using System.Collections.Generic;
using System.Text;

interface IProbability : IProvider {
    double[] GetWordProbability(IWordPropertyProvider provider);
    double[] GetLetterProbability(IAlphabet provider);
}
