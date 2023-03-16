using ATM.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL.Interfaces
{
    public interface IAtmServices
    {
        void Transfer(long amount, int account, string discription);
        void Withdrawal(long amount, string discription);
        void Deposit(long amount,int account,  string discription);
        void Recharge(long amount, string biller);
    }
}
