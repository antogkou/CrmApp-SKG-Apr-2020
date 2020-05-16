using CrmApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmMVC.Models
{
    public class DataModels
    {
        public List<Product> Products { get; set; }
    }

    public class CustomerModel
    {
        public List<Customer> Customers { get; set; }
    }
}
