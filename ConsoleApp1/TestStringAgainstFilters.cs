using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public class TestStringAgainstFilters : ITestStringAgainstFilters
    {
        public bool testStringAgainstFilters(string wordToProcess, List<ITextFilter> textFilters)
        {
            bool removeWord = false;

            foreach (ITextFilter textFilter in textFilters)
            {
                if (textFilter.checkFilterCondition(wordToProcess) == true)
                {
                    removeWord = true;
                    break;
                }
            }
            return removeWord;
        }
    }
}
