using ATM.BLL.Implementations;
using System;

namespace ATM.UI.Forms
{
    public class DepositForm: UserAuthService
    {
        public static void Depositform()
        {
            Console.WriteLine("\tDEPOSIT CASH\n");

            var deposit = new AtmServices();

            Console.WriteLine("Enter amount to withdraw");
            var amount = Console.ReadLine();

            Console.WriteLine("Enter discription");
            var description = Console.ReadLine();

            var limit = 1000000;

            if (long.Parse(amount) <= 1 || long.TryParse(amount.ToString(), out _) == false)
            {
                Console.WriteLine("Inalid Amount: Amount must be greater than zero");
            }

            if (long.Parse(amount) > limit)
            {
                Console.WriteLine("Amount must be less than a million");
            }

            if (Balance - int.Parse(amount) <= 1)
            {
                Console.WriteLine("Unable to compplete Transation: Your balance is low");
            }

            deposit.Deposit(int.Parse(amount), Account, description);
        }
    }
}
