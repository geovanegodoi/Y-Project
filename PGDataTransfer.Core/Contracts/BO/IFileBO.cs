using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Core.Contracts.BO
{
    public interface IFileBO
    {
        bool FileExist(FileTO file);
        bool CompareFileSizes(FileTO local, FileTO remote);
        void AddFileToCollection(FileTO to);
        ICollection<FileTO> GetFileCollection();
    }
}
