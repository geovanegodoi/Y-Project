using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Core.TO
{
    public abstract class BasePart
    {
        public string SerialNo { get; set; }

        public string PPN { get; set; }

        public DateTime DateTime { get; set; }
    }
}
