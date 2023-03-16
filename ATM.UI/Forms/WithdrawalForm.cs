using ATM.BLL.Implementations;

namespace ATM.UI.Forms
{
    internal class WithdrawalForm: UserAuthService
    {
        public static void Withdrawal()
        {
            Console.WriteLine("MAKE A WITHDRAWAL\n");

            var withdrawService = new AtmServices();

            Console.WriteLine("Enter amount to withdraw");
            var amounttotransfer = Console.ReadLine();

            Console.WriteLine("Enter description");
            var discription = Console.ReadLine();

            var limit = 20000;
            if (long.Parse(amounttotransfer) <= 1 || long.TryParse(amounttotransfer.ToString(), out _) == false)
            {
                Console.WriteLine("Inalid Amount: Amount must be greater than zero");
            }
            else if (long.Parse(amounttotransfer) > limit)
            {
                Console.WriteLine("Amount limit is #20000");
            }

            else if (Balance - int.Parse(amounttotransfer) <= 1)
            {
                Console.WriteLine("Unable to compplete Transation: Your balance is low");
            }
            withdrawService.Withdrawal(long.Parse(amounttotransfer), discription);
        }
    }
}
