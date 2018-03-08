using System.Collections.Generic;

namespace PGDataTransfer.Core.TO
{
    public class SKDTO : BasePartTO
    {
        public string PGMpn { get; set; }

        public ICollection<SubAssemblyTO> Parts { get; set; }

        public CartonTO Carton { get; set; }

        public PalletTO Pallet { get; set; }
    }
}
