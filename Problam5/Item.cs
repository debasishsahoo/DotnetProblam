using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam5
{
    class Item : OrderDetail
    {
        public Item()
        {
            shippingWeight = "";
            description = "";
        }

        protected string shippingWeight;
        protected string description;

        public double getPriceForQuantity()
        {
            return 0;
        }

        public double getWeight()
        {
            return 0;
        }

        public string GetShippingWeight()
        {
            return shippingWeight;
        }

        public string GetDescription()
        {
            return description;
        }
        public void SetShippingWeight(string shippingWeight)
        {
            this.shippingWeight = shippingWeight;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}
