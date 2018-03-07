using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Core.TO
{
    public class SKDTO : BasePart
    {
        public string PGMpn { get; set; }

        public ICollection<SubAssemblyTO> Parts { get; set; }

        public CartonTO Carton { get; set; }

        public PalletTO Pallet { get; set; }
    }
}
