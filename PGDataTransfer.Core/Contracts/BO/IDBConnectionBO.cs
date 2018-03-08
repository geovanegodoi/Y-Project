using PGDataTransfer.Core.TO;

namespace PGDataTransfer.Core.Contracts.BO
{
    public interface IDBConnectionBO : IConnectionBO
    {
        void BeginTransaction();
        void RollbackTransaction();
        void CommitTransaction();
        void UploadData(DBDataTO to);
    }
}
