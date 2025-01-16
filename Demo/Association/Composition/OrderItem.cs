using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public required Product Product { get; set; }

    }
}
