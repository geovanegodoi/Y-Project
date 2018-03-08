using PGDataTransfer.Core.TO;

namespace PGDataTransfer.Core.Contracts.BO
{
    public interface IConnectionBO
    {
        void OpenConnection(OpenConnectionTO to);

        void CloseConnection();
    }
}
