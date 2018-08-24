interface IAlphabet : IProvider {
    string GetAlphabet();
    int GetTotalAlphabetLetterFrequency();
    int[] GetAlphabetLetterFrequencies();
}
