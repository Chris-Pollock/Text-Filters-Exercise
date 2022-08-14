using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilterByLength : ITextFilter
    {
        private int lengthToFilterBy;
        public TextFilterByLength(int maxLengthToFilterOut)
        {
            this.lengthToFilterBy = maxLengthToFilterOut;
        }
        public bool checkFilterCondition(string wordToProcess)
        {
            if (wordToProcess.Length <= lengthToFilterBy)
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
