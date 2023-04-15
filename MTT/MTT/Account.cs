using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT
{
    public class Account
    {
        public string IBAN;
        protected float Amount;
        public bool Transaction(string account)
        {
            if (account.Equals(IBAN))
            {
                return true;
            }
            return false;
        }
    }
}
