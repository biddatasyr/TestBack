using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Models
{
    public class Rating
    {
        public long Id { get; set; }
        public int Stars { get; set; }


        public Product Product { get; set; }
    }
}
