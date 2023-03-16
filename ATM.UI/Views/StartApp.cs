using ATM.UI.Forms;
using System.ComponentModel.DataAnnotations;

namespace ATM.UI.Views
{
    public class StartApp
    {
        public static void Startapp()
        {

            Console.WriteLine("\t*************************************");
            Console.WriteLine("\t*      Welcome to Germane Bank      *");
            Console.WriteLine("\t*************************************");

        }

        public static void AccessOptions()
        {
            Console.WriteLine(" select option:\n \n =>1. Login  \n\n =>2. Reset pin ");

            string? option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    LoginForm.Login();
                    TransactionOptions();
                    break;
                case "2":
                    Console.Clear();
                    ResetPinForm.Reset();
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    AccessOptions();
                    break;
            }
        }

        public static void TransactionOptions()
        {
            Console.WriteLine("\tSELECT TRANSACTION OPTION\n");
            Console.WriteLine(" =>1. Withdraw                  =>2. Transfer \n\n");
            Console.WriteLine(" =>3. Deposit                   =>4. Recharge ");

            bool Validate = true;
            
            string? tranoption = Console.ReadLine();
            switch (tranoption)
            {
                case "1":
                    Console.Clear();
                    WithdrawalForm.Withdrawal();
                    ContinueOption();
                    break;
                case "2":
                    Console.Clear();
                    TransferForm.Transferform();
                    ContinueOption();

                    break;
                case "3":
                    Console.Clear();
                    DepositForm.Depositform();
                    ContinueOption();

                    break;
                case "4":
                    Console.Clear();
                    RechargeForm.Rechargeform();
                    ContinueOption();

                    break;

                default:
                    Console.WriteLine("Invalid Option\n");
                    ContinueOption();
                    break;
            }           
        }

        public static void ContinueOption()
        {
            Console.WriteLine("Do you want to carry out another transaction....y/n");

            var Option = Console.ReadLine().ToLower();
            switch (Option)
            {
                case "y":
                    AccessOptions();
                    break;
                case "n":
                    Console.WriteLine( "\nTHANK YOU!");
                    break;
                default:
                    ContinueOption();
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
