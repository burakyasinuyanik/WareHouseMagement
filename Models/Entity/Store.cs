using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMagement.Models.Entity
{
    public class Store
    {
        public int StoreID { get; set; }
        public string? StoreName { get; set; } 
        public string? StoreManager { get; set; } 
        public string? StoreAddress { get; set; } 
    }
}