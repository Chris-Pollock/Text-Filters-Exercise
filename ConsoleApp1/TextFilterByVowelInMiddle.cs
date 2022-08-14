using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilterByVowelInMiddle : ITextFilter
    {
        public bool checkFilterCondition(string wordToProcess)
        {
            if (wordToProcess == "jar")
            {
                var x = 1;
            }
            if (wordToProcess.Length % 2 == 0)
            {
                int index1 = wordToProcess.Length / 2;
                int index2 = index1 - 1;
                if (isVowel(wordToProcess[index1]) || isVowel(wordToProcess[index2]))
                {
                    return true;
                }
            }
            else if (wordToProcess.Length == 1)
            {
                if (isVowel(wordToProcess[0]))
                {
                    return true;
                }
            }
            else
            {
                int index = wordToProcess.Length - 1;
                index = index / 2;
                if (isVowel(wordToProcess[index]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool isVowel(char character)
        {
            switch (character.ToString().ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    return true;
                default: return false;
            }
        }
    }
}
