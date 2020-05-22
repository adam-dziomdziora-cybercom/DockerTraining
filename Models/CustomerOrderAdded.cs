using System;

namespace Models
{
    public class CustomerOrderAdded
    {
        public Guid RequestId { get; set; }

        public string CustomerOrderId { get; set; }
    }
}