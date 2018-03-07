using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Controllers
{
    class DownloadController
    {
        public DownloadController()
        {
            var oSKD = new SKDTO
            {
                SerialNo    = "DV6",
                PGMpn       = "PGMpn",
                PPN         = "PPN",
                Carton      = new CartonTO { SerialNo = "Carton", DateTime = DateTime.Now },
                DateTime    = DateTime.Now,
                Pallet      = new PalletTO { SerialNo = "Pallet", DateTime = DateTime.Now },
                Parts       = new List<SubAssemblyTO>
                {
                    new SubAssemblyTO() { PartName = "CAM", SerialNo = "123", PPN = "663", DateTime = DateTime.Now },
                    new SubAssemblyTO() { PartName = "BTY", SerialNo = "123", PPN = "663", DateTime = DateTime.Now },
                    new SubAssemblyTO() { PartName = "CGS", SerialNo = "123", PPN = "663", DateTime = DateTime.Now },
                    new SubAssemblyTO() { PartName = "HSG", SerialNo = "123", PPN = "663", DateTime = DateTime.Now },
                }
            };
        }
    }
}
