using System;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        public DateTime OrderPlacementDate { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}