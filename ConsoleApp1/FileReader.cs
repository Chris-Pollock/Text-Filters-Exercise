using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    public static class FileReader
    {
        public static string readStringFromFile(string directory)
        {
            string text = System.IO.File.ReadAllText(directory);
            return text;
        }
    }
}
