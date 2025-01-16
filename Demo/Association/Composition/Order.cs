using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Order
    {
        public int Id { get; set; }
        public required string userEmail { get; set; }
        public required  List<OrderItem> items { get; set; }
    }
}
