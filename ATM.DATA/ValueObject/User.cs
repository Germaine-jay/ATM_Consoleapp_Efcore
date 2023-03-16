using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL.ValueObject
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Accountnumber { get; set; }
        public long Accountbalance { get; set; }
        public string Accountpin { get; set; }

    }
}
