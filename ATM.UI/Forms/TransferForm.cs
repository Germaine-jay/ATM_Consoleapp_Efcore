using ATM.BLL.Implementations;
using System;

namespace ATM.UI.Forms
{
    public class TransferForm: UserAuthService
    {
        public static void Transferform()
        {
            Console.WriteLine("MAKE A TRANSFER\n");

            var transfer = new AtmServices();

            Console.WriteLine("Enter amount to Transfer");
            var amounttotransfer = Console.ReadLine();

            Console.WriteLine("Enter Destinstion Account");
            var account = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter description");
            var description = Console.ReadLine();

            var limit = 1000000;
            if (long.Parse(amounttotransfer) <= 1 || long.TryParse(amounttotransfer.ToString(), out _) == false)
            {
                Console.WriteLine("Inalid Amount: Amount must be greater than zero");
            }
            if(long.Parse(amounttotransfer) > limit)
            {
                Console.WriteLine("Amount must be less than a million");
            }

            if (Balance - int.Parse(amounttotransfer) <= 1)
            {
                Console.WriteLine("Unable to compplete Transation: Your balance is low");
            }
            transfer.Transfer(long.Parse(amounttotransfer), account, description);
        }
    }
}
