using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get;set; }

        [Column(TypeName = "decimal(18.4)")]
        public double Price { get; set; }


        public Supplier Supplier { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
