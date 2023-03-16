using ATM.BLL.Interfaces;
using ATM.DATA.DataAccess;

namespace ATM.BLL.Implementations
{
    public class UserAuthService : IUserAuthServices
    {
        public static long Balance;
        public static int Account;
        public static string? FirstName;
        public static string? LastName;

        public bool LoginCustomer(int accountnumber, string accountpin)
        {   
            var data = GetData.UserQuaery().SingleOrDefault(u=> u.Account.AccountNumber == accountnumber && u.Account.Accountpin == accountpin);
            
            if (data != null)
            {
                Balance = data.Account.AccountBalance;
                Account = data.Account.AccountNumber;
                FirstName = data.FirstName;
                FirstName = data.FirstName;

                return true;
            }           
            return false;
        }

        public bool ResetPin(int? accountnumber, string? oldpin, string newpin)
        {
            bool output = false;
            var data = GetData.UserQuaery().SingleOrDefault(u => u.Account.AccountNumber == accountnumber && u.Account.Accountpin == oldpin);
          
            if (data != null)
            {
                data.Account.Accountpin = newpin;
                var response = GetData._dbContext.SaveChanges() > 0 ? output = true : output = false;
                return response;
            }          
            return output;
        }
    }
}
