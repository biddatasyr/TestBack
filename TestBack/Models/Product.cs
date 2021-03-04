using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Models
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Supplier Supplier { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
