using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Products.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string DeliveryOn { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
