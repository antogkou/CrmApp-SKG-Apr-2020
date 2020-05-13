using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public interface ICustomerManager
    {
        Customer CreateCustomer(CustomerOption custOption);
        Customer FindCustomerById(int customerId);
        List<Customer> FindCustomerByName(CustomerOption custOption);
        Customer Update(CustomerOption custOption, int customerId);
        List<Customer> GetAllCustomers();
        bool DisableCustomerById(int id);
        bool EnableCustomerById(int id);
        bool HardDeleteCustomerById(int id);
    }
}
