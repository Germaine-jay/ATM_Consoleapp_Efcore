using ATM.BLL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI.Forms
{
    public class ResetPinForm
    {
        public static void Reset()
        {
            Console.WriteLine(" Enter your account number, your old pin and new pin\n");

            UserAuthService userAuthService = new UserAuthService();

            Console.WriteLine("Enter account number");
            var accountnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter old pin");
            var accountoldpin = Console.ReadLine();

            Console.WriteLine("Enter new pin");
            var accountnewpin = Console.ReadLine();

           var auth =  userAuthService.ResetPin(accountnumber, accountoldpin, accountnewpin);
           if(auth == true)
            {
                LoginForm.Login();
            }
            else { Console.WriteLine("Incorrect account number or pin\nTry again"); Reset(); };

        }
    }
}
