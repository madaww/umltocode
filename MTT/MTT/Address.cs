using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT
{
    struct Address
    {
        public string street;
        public string city;
        public string state;
        public int postal_code;
        public string country;
        public bool validate()
        {
            if (country.Length==0)
            {
                return false;
            }

            return true;
        }

    }
}
