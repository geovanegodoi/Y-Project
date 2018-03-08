using PGDataTransfer.Core.Contracts.Controller;
using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Controllers
{
    class DownloadController : IDownloadController
    {
        public ICollection<FileTO> DownloadFiles(DownloadFilesTO to)
        {
            throw new NotImplementedException();
        }
    }
}
