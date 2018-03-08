using PGDataTransfer.Core.TO;
using System.Collections.Generic;

namespace PGDataTransfer.Core.Contracts.Controller
{
    public interface IFileController
    {
        ICollection<DBDataTO> ConvertFiles(ICollection<FileTO> files);
    }
}
