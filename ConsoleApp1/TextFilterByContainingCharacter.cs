using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilterByContainingCharacter : ITextFilter
    {
        private char characterToFilterBy;
        public TextFilterByContainingCharacter(char characterToFilterBy)
        {
            this.characterToFilterBy = characterToFilterBy;
        }
        public bool checkFilterCondition(string wordToProcess)
        {
            if (wordToProcess.Contains(characterToFilterBy))
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }
    }
}
