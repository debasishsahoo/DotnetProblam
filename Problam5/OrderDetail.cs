using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam5
{
    class OrderDetail
    {
        public OrderDetail()
        {
            quantity = 0.0;
            taxStatus = "";
        }
        protected Item[] i;
        protected double quantity;
        protected string taxStatus;

        public double calcSubTotal()
        {
            return 0;
        }

        public double calcWeight()
        {
            return 0;
        }

    }
}
