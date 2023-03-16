using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL.Interfaces
{
    public interface IUserAuthServices
    {
        bool LoginCustomer(int accountnumber, string pin);
        bool ResetPin(int? accountnumber, string? oldpin, string newpin);
    }
}
