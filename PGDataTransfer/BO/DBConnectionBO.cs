using PGDataTransfer.Core.Contracts.BO;
using PGDataTransfer.Core.TO;
using System;

namespace PGDataTransfer.BO
{
    public class DBConnectionBO : IDBConnectionBO
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection(OpenConnectionTO to)
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public void UploadData(DBDataTO to)
        {
            throw new NotImplementedException();
        }
    }
}
