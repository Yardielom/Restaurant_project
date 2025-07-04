using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1.models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public string Status { get; set; } = "Received";

        public decimal Total => Dishes.Sum(d => d.Price);

        public string Username { get; set; }       
        public string Address { get; set; }        
    }
}
