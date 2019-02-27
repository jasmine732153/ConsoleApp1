using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderProcessor
    {
        private redaonly ShippingCalculator_shippingCalculator;
        public OrderProcessor()
        {
            _ShippingCalculator = new ShippingCalculator();
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("this order is already processed");
            order.Shipment = new Shipment
            {
                Cost = ShippingCalculator.CalculatingShipping(order);
            ShippingDate = DateTime.Today.AddDays(1);
        }
        }

        }
    }
}
