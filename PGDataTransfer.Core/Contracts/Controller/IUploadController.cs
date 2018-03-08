using PGDataTransfer.Core.TO;
using System.Collections.Generic;

namespace PGDataTransfer.Core.Contracts.Controller
{
    public interface IUploadController
    {
        void UploadData(ICollection<DBDataTO> collection);
    }
}
