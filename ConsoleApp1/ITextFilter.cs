using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public interface ITextFilter
    {
        public bool checkFilterCondition(string wordToProcess);
    }
}
