using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Options
{
    public class ProductOption
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal TotalCost { get { return Price * Quantity; } }
    }
}
