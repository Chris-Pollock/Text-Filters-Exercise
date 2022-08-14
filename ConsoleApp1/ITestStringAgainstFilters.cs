using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public interface ITestStringAgainstFilters
    {
        public bool testStringAgainstFilters(string wordToProcess, List<ITextFilter> textFilters);
    }
}
