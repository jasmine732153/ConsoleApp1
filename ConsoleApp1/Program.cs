using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    class Program
{


    static void Main(string[] args)
    {
        var OrderProcessor = new OrderProcessor();
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        OrderProcessor.Process(order);
    }
    
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
public class ShippingCalculator {
    public float CalculateShipping(Order order)
    {
        if (order.TotalPrice < 30f) return order.TotalPrice = 0.1f;
        return 0;

    }
}