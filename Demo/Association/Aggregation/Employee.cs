using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation

{
    internal class Employee
    {
        public int Id { get; set; }
        public  required string Fname { get; set; }
        public  required string Lname { get; set; }

    }
}
