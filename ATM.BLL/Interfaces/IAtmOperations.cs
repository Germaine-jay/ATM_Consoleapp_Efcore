using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL.Interfaces
{
    public interface IAtmOperations
    {
        string TransactionOperation(long amount, string discription, string type, DateTime date);
        string DepositTransactionOperation(long amount, string discription, string type, DateTime date);
        string TransferTransactionOperation(long amount, int account, string discription, string type, DateTime date);
    }
}
