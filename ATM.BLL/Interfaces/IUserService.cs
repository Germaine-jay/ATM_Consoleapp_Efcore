using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL.Interfaces
{
    public interface IUserService
    {
        string SetBalance(int accountnumber, long balance);
        string SetRecieverBalance(long amount, int accountnumber);
    }
}
