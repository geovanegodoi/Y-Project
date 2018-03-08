using PGDataTransfer.Core.TO;
using System.Collections.Generic;

namespace PGDataTransfer.Core.Contracts.BO
{
    public interface IFTPConnectionBO : IConnectionBO
    {
        ICollection<FileTO> ListFiles(string url);
        FileTO DownloadFile(FileTO to);
    }
}
