using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMagement.Models.Entity
{
    public class WarehouseProducts 
    {
        public int ProductID { get; set; } 
        public string? ProductName { get; set; } 
        public int CategoryID { get; set; } 
        public int Count { get; set; } 
    }
}