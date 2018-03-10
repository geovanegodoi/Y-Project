using PGDataTransfer.Core.Contracts.BO;
using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;

namespace PGDataTransfer.BO
{
    public class FTPConnectionBO : IFTPConnectionBO
    {
        public void OpenConnection(OpenConnectionTO to)
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public ICollection<FileTO> ListFiles(string url)
        {
            throw new NotImplementedException();
        }

        public FileTO DownloadFile(FileTO to)
        {
            throw new NotImplementedException();
        }
    }
}
