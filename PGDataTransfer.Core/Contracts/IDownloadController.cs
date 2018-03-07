using PGDataTransfer.Core.TO;
using System.Collections.Generic;

namespace PGDataTransfer.Core.Contracts
{
    public interface IDownloadController
    {
        ICollection<FileTO> DownloadFiles(DownloadFilesTO to);
    }
}
