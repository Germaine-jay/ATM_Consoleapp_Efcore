using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DATA.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public string TransactionType { get; set; }
        public int Account { get; set; }
        public string TransactionDiscription { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
