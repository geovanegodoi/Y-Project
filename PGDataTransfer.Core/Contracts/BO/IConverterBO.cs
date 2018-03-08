using PGDataTransfer.Core.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataTransfer.Core.Contracts.BO
{
    public interface IConverterBO
    {
        void ConvertFileToObject(FileTO to);
        ICollection<DBDataTO> GetObjectCollection();
    }
}