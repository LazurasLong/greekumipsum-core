class GreekAlphabet : IAlphabet {
    public string GetAlphabet() {
        return "ΨΖΞΒΦΧΓΘΔΛΜΩΟΡΚΗΤΣΠΙΕΝΥΑ";
    }
    
    public int GetTotalAlphabetLetterFrequency() {
        return 692976;
    }
    
    public int[] GetAlphabetLetterFrequencies() {
        return new int[] { 960, 1389, 2248, 3667, 4072, 5329, 10908, 11331, 12948, 18595, 20009, 21946, 21875, 23529, 24408, 27460, 40403, 52241, 52585, 57469, 66075, 67953, 68389, 77187 };
    }
}
