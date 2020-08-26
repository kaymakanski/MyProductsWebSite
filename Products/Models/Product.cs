using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Products.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string DeliveryOn { get; set; }

    }
}
