using System;
using System.Collections.Generic;
using System.Text;

class GreekumIpsum {
    private IAlphabet alphabet;
    private IWordPropertyProvider wordPropertyProvider;
    private IProbability probability;
    
    private char lastAlphabetLetter;
    private Random randomGenerator = new Random();
    
    private bool startingZero = false;
    private bool errored = false;

    public char NextCharacter() {
        try {
            double r = randomGenerator.NextDouble(), sum = 0;
            int idx = 0;
            foreach (char n in alphabet.GetAlphabet()) {
                if (r <= (sum = sum + probability.GetLetterProbability(alphabet)[idx++])) {
                    if (lastAlphabetLetter == n) return NextCharacter();
                    lastAlphabetLetter = n;
                    return n;
                }
            }
            errored = true;
        } catch(Exception e) {
            errored = true;
        }
        
        return '?';
    }

    public string NextWord() {
        try {
            double runningtotal = 0.0, randValue = randomGenerator.NextDouble();
            int length = 5, idx = 0;
            string word = "";

            foreach (int obj in wordPropertyProvider.GetWordLengths()) {
                runningtotal += probability.GetWordProbability(wordPropertyProvider)[idx];
                if (runningtotal > randValue) {
                    length = obj;
                    break;
                }
                idx++;
            }
            
            for (int i = 0; i < length; i++) {
                word += Char.ToLower(NextCharacter());
            }
            return word;
        } catch(Exception e) {
            errored = true;
        }
        
        return "???";
    }
    
    public string NextWord(int amount) {
        string ret = "";
        for(int i = 0; i < amount; i++) {
            ret += NextWord();
            ret += " ";
        }
        return ret;
    }

    public string NextSentence(bool isStartOfWord) {
        try {
            string sentence = "";
            int length = randomGenerator.Next(2,6);
            if(isStartOfWord) {
                length--;
                char[] wrd = NextWord().ToCharArray();
                wrd[0] = Char.ToUpper(wrd[0]);
                sentence += new string(wrd);
                sentence += " ";
            }
            for(int idx = 0; idx < length; idx++) {
                sentence += NextWord();
                sentence += " ";
            }

            sentence = sentence.Remove(sentence.Length - 1);
            
            if(randomGenerator.Next() % 2 == 0) {
                sentence += ". ";
            } else {
                sentence += ", ";
                sentence += NextSentence(false);
            }

            return sentence;
        } catch(Exception e) {
            errored = true;
        }
        
        return "???";
    }
    
    public string NextSentence(bool isStartOfWord, int amount) {
        string ret = "";
        for(int i = 0; i < amount; i++)
            ret += NextSentence(isStartOfWord);
        return ret;
    }
    
    public string NextParagraph() {
        try {
            return "\t" + NextSentence(true, randomGenerator.Next() % 15 + 12);
        } catch(Exception e) {
            errored = true;
        }
        
        return "???";
    }
    
    public bool HasErrored() {
        return errored;
    }
    
    public void ClearError() {
        errored = false;
    }

    public GreekumIpsum (bool startClean) {
        if(!startClean) {
            alphabet = new GreekAlphabet();
            wordPropertyProvider = new GreekWordPropertyProvider();
            probability = new GreekProbability();
        } else {
            alphabet = new CleanGreekAlphabet();
            wordPropertyProvider = new CleanGreekWordPropertyProvider();
            probability = new GreekProbability();
            startingZero = true;
        }
    }
}
