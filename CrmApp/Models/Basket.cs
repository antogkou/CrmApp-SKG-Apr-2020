using CrmApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrmApp
{
    public class Basket
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }


    }
}