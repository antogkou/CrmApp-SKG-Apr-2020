using System;
using System.Collections.Generic;

namespace CrmApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance { get; set; }

        public List<Basket> Baskets { get; set; }

    }
}