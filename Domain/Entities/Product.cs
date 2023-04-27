using OnlineMagazin.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMagazin.Domain.Entities
{
    public class Product:Auditable
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
