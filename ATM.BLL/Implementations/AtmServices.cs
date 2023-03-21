using ATM.BLL.Interfaces;
using ATM.DATA.Models;
using System;


namespace ATM.BLL.Implementations
{
    public class AtmServices : IAtmServices
    {
        AtmOperations atmOperations = new AtmOperations();
        public void Deposit(long amount, int account, string discription)
        {
            atmOperations.DepositTransactionOperation(amount, discription, "Deposit", DateTime.Now);
        }

        public void Recharge(long amount, string biller)
        {
            atmOperations.TransactionOperation(amount, biller, "Recharge", DateTime.Now);
        }

        public void Transfer(long amount, int account, string discription)
        {
            atmOperations.TransferTransactionOperation(amount, account,discription, "Transfer", DateTime.Now);
        }
      
        public void Withdrawal(long amount, string discription)
        {
            atmOperations.TransactionOperation(amount, discription, "Withdraw", DateTime.Now);
        }
    }

    
}
