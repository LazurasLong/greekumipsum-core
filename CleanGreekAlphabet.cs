
using System;
using System.Collections.Generic;
using System.Text;

namespace Greekum {
    class CleanGreekAlphabet : IAlphabet {
        int[] alphabetFrequencies = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        
        public string GetAlphabet() {
            return "ΨΖΞΒΦΧΓΘΔΛΜΩΟΡΚΗΤΣΠΙΕΝΥΑ";
        }
        
        public int GetTotalAlphabetLetterFrequency() {
            int total = 0;
            for(int i = 0; i < alphabetFrequencies.Length; i++) {
                total += alphabetFrequencies[i];
            }
            return total;
        }
        
        public int[] GetAlphabetLetterFrequencies() {
            return alphabetFrequencies; 
        }
    }
}
