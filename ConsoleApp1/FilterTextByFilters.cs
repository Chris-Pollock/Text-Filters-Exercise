using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public class FilterTextByFilters
    {
        List<ITextFilter> listOfFilters;

        public FilterTextByFilters(List<ITextFilter> listOfFilters)
        {
            this.listOfFilters = listOfFilters;
        }
        public string filterStringByFilters(string textToFilter, ITestStringAgainstFilters testStringAgainstFilters)
        {
            //no longer agree with my decision to just split on a space.
            //Would probably go character by character instead and build up each word, with some extra logic here (and in other places) to handle punctuation, linebreaks, etc, to preserve them in place.
            //for now have just assumed punctuation is part of the word.
            string[] textArrayToFilter = textToFilter.Split(' '); 
            StringBuilder filteredStringBuilder = new StringBuilder();
            foreach (string wordToTest in textArrayToFilter)
            {
                if (testStringAgainstFilters.testStringAgainstFilters(wordToTest, listOfFilters) == false)
                {
                    filteredStringBuilder.Append(wordToTest + " ");
                }
            }
            return filteredStringBuilder.ToString();
        }
    }
}
