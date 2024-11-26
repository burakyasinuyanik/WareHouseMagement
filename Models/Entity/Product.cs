using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMagement.Models.Entity
{
    public class Product
    {
        public int ProductID { get; set; } 
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public int Quantity { get; set; }
        public string StoreName { get; set; } = string.Empty;
    }
}