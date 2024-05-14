using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterDomain.Interfaces
{
    public interface ITextReader
    {
        List<string> ReadFromFile(string filePath);
    }
}
