
using System;
using System.Collections.Generic;
using System.Text;

class GreekProbability : IProbability {
    public double[] GetWordProbability(IWordPropertyProvider provider) {
        double[] probabilities = new double[26];
        for (int idx = 0; idx < provider.GetWordLengthFrequencies().Length; idx++)
            probabilities[idx] = (double)provider.GetWordLengthFrequencies()[idx] / provider.GetTotalWordLengthsFrequencies();
        return probabilities;
    }
    
    public double[] GetLetterProbability(IAlphabet provider) {
        double[] probabilities = new double[24];
        for (int idx = 0; idx < provider.GetAlphabetLetterFrequencies().Length; idx++)
            probabilities[idx] = (double)provider.GetAlphabetLetterFrequencies()[idx] / provider.GetTotalAlphabetLetterFrequency();
        return probabilities;
    }
}
