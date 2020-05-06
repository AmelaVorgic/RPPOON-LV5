using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class ShippingService
    {
        private double WeightPrice;
        public ShippingService(double WeightPrice)
        {
            this.WeightPrice = WeightPrice;
        }
        public double CalculatePrice(IShipable item)
        {
            return this.WeightPrice * item.Weight;
        }
    }
}
