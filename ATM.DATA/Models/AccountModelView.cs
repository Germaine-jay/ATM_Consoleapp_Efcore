using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DATA.Models
{
    public class Account
    {    
        public int AccountNumber { get; set; }
        public long AccountBalance { get; set;}
        public string Accountpin { get; set;}
        public int CustomerId { get; set;}
        public Customer Customer { get; set; }
    }
}
