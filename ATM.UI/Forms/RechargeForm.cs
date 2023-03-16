using ATM.BLL.Implementations;
using System;

namespace ATM.UI.Forms
{
    internal class RechargeForm: UserAuthService
    {
        public static void Rechargeform()
        {
            Console.WriteLine("\tRECHARGE YOUR MOBILE\n");

            var recharge = new AtmServices();

            Console.WriteLine("Enter amount to Recharge");
            var amount = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Network");
            string? biller = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string? Phonenumber = Console.ReadLine();

            recharge.Recharge(amount, biller);

        }
    }
}
