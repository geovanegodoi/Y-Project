using System;

namespace PGDataTransfer.Core.TO
{
    public abstract class BasePartTO
    {
        public string SerialNo { get; set; }

        public string PPN { get; set; }

        public DateTime DateTime { get; set; }
    }
}
