using ATM.BLL.Interfaces;
using ATM.DATA.ValueObject;
using ATM.DATA.DataAccess;
using System;


namespace ATM.BLL.Implementations
{    
    public class AtmOperations : IAtmOperations
    {
        public static long AccountBalance = UserAuthService.Balance;
        public static int AccountNumber = UserAuthService.Account;


        protected static List<Transaction> AllTransactions = new List<Transaction>();
        public string TransactionOperation(long amount, string discription, string type, DateTime date)
        {
            
            var Balance = AccountBalance - amount;
            var output = new UserService().SetBalance(AccountNumber, Balance);

            if(output== "Successful")
            {
                Console.WriteLine($"{discription} of #{amount} Successful");
                var Transac = new Transaction(-amount, discription, type, date);
                AllTransactions.Add(Transac);
            }

            return $"{discription} of #{amount} UnSuccessful";

            
        }
        public string DepositTransactionOperation(long amount, string discription, string type, DateTime date)
        {
            
            var Balance = AccountBalance + amount;
            var output = new UserService().SetBalance(AccountNumber, Balance);
            if (output == "Successful")
            {
                var Transac = new Transaction(amount, discription, type, date);
                AllTransactions.Add(Transac);

                return $"{discription} of #{amount} Successful";
            }
            return $"{discription} of #{amount} Unuccessful";

            
        }

        public string TransferTransactionOperation(long amount, int account, string discription, string type, DateTime date)
        {
            
            var Balance = AccountBalance - amount;
            var output = new UserService().SetBalance(AccountNumber, Balance);
            if(output == "Successful")
            {
                var data = GetData.UserQuaery().SingleOrDefault(u => u.Account.AccountNumber == account);
                new UserService().SetRecieverBalance(amount, account);

                var Transac = new Transaction(-amount, account, discription, type, date);
                AllTransactions.Add(Transac);

                return $"{discription} of #{amount} to {data.FirstName} {data.LastName} Successful";
            }

            return $"{discription} of #{amount} Unuccessful";
          
        }
    }
}
