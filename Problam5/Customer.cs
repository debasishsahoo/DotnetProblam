using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam5
{
    class Customer
    {
        public Customer()
        {
            name = "";
            address = "";
        }
        protected string name;
        protected string address;
        protected Order[] o;
    }
}
