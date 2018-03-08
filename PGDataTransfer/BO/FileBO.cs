using PGDataTransfer.Core.Contracts.BO;
using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;

namespace PGDataTransfer.BO
{
    public class FileBO : IFileBO
    {
        public void AddFileToCollection(FileTO to)
        {
            throw new NotImplementedException();
        }

        public bool CompareFileSizes(FileTO local, FileTO remote)
        {
            throw new NotImplementedException();
        }

        public bool FileExist(FileTO file)
        {
            throw new NotImplementedException();
        }

        public ICollection<FileTO> GetFileCollection()
        {
            throw new NotImplementedException();
        }
    }
}
