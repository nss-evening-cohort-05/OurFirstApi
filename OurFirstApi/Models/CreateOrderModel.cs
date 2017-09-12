using System.Collections.Generic;

namespace OurFirstApi.Models
{
    public class CreateOrderModel
    {
        public int CustomerId { get; set; }
        public List<OrderLineItem> LineItems { get; set; }
    }

    public class OrderLineItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }   
    }
}