using ATM.BLL.Interfaces;
using ATM.DATA.DataAccess;
using System;

namespace ATM.BLL.Implementations
{
    public class UserService : IUserService
    {
        public string SetBalance(int accountnumber, long balance)
        {
            var querydata = GetData.UserQuaery()?.SingleOrDefault(u => u.Account.AccountNumber == accountnumber);
            querydata.Account.AccountBalance = balance;

            var msg = GetData._dbContext.SaveChanges() > 0 ? "Successful" : "Failed";

            return msg;
        }

        public string SetRecieverBalance(long amount, int accountnumber)
        {

            var querydata = GetData.UserQuaery().SingleOrDefault(u => u.Account.AccountNumber == accountnumber);
            if (querydata != null)
            {
                querydata.Account.AccountBalance += amount;
                var msg = GetData._dbContext.SaveChanges() > 0 ? "Transaction Successful" : "Transaction Failed";

                return msg;
            }
          
            return "Destination Account does not exist";
        }
    }
}
