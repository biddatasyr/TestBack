using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Models
{
    public class Supplier
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }


        public IEnumerable<Product> Products { get; set; }
    }
}
