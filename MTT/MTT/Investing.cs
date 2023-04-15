using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT
{
    public class Investing : Account
    {
        public float Interest;
        public void ApplyInterest()
        {
            Amount = Amount + Interest;
        }
    }
}
