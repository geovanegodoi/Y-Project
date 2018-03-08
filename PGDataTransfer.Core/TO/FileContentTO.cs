using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Core.TO
{
    public class FileContentTO
    {
        public ICollection<Dictionary<string, string>> Rows { get; set; }
    }
}
