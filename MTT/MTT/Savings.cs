using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT
{
    public class Savings : Account
    {
        private float ProtectedAmount;
        public void LiberateSavings()
        {
            Amount = Amount + ProtectedAmount;
            ProtectedAmount = 0;
        }
    }
}
