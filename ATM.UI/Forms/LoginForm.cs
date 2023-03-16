using ATM.BLL.Implementations;
using System;


namespace ATM.UI.Forms
{
    public class LoginForm: UserAuthService
    {
        public static void Login()
        {
            Console.WriteLine("ENTER your account number and pin to login\n");
            
            UserAuthService userAuthService = new UserAuthService();

            Console.WriteLine("\nEnter account number");
            var accountnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter account pin");
            string? accountpin = Console.ReadLine();

            if (accountpin != "0000")
            {
                var auth = userAuthService.LoginCustomer(accountnumber, accountpin);
                if (auth == true)
                {
                    Console.WriteLine($"Welcome {FirstName} {LastName}");
                }
                else { Console.WriteLine("Incorrect Account Number or pin, Try Again"); Login(); };
            }
            else
            {
                Console.WriteLine("Please reset your pin first then login");
                ResetPinForm.Reset();
            };

        }
    }
}
