using PGDataTransfer.Core.TO;
using System.Collections.Generic;

namespace PGDataTransfer.Core.Contracts
{
    public interface IFileController
    {
        ICollection<SKDTO> ParserFiles(ICollection<FileTO> files);
    }
}
