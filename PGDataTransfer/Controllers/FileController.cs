using PGDataTransfer.Core.Contracts.Controller;
using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;

namespace PGDataTransfer.Controllers
{
    public class FileController : IFileController
    {
        public ICollection<DBDataTO> ConvertFiles(ICollection<FileTO> files)
        {
            throw new NotImplementedException();
        }
    }
}
