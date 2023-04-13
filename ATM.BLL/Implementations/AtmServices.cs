using ATM.BLL.Interfaces;
using ATM.DATA.Models;
using System;


namespace ATM.BLL.Implementations
{
    public class AtmServices : IAtmServices
    {
        private readonly AtmOperations _atmOperations;
        public AtmServices(AtmOperations atmOperations)
        {
            _atmOperations = atmOperations;
        }
        public void Deposit(long amount, int account, string discription)
        {
            _atmOperations.DepositTransactionOperation(amount, discription, "Deposit", DateTime.Now);
        }

        public void Recharge(long amount, string biller)
        {
            _atmOperations.TransactionOperation(amount, biller, "Recharge", DateTime.Now);
        }

        public void Transfer(long amount, int account, string discription)
        {
            _atmOperations.TransferTransactionOperation(amount, account,discription, "Transfer", DateTime.Now);
        }
      
        public void Withdrawal(long amount, string discription)
        {
            _atmOperations.TransactionOperation(amount, discription, "Withdraw", DateTime.Now);
        }
    }

    
}
