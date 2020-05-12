using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public interface ICustomerManager
    {
        List<Customer> GetAllCustomers();
        List<Customer> FindCustomerByName(CustomerOption custOption);
        Customer GetCustomer(int id);
        Customer PostCustomer(CustomerOption custOpt);
        Customer PutCustomer(int id, CustomerOption custOpt);
        bool HardDeleteCustomer(int id);
        bool DisableCustomerById(int id);
        bool EnableCustomerById(int id);
        Customer FindCustomerById(int id);
        Customer CreateCustomer(CustomerOption custOpt);
        Customer Update(CustomerOption custOpt, int id);
        bool HardDeleteCustomerById(int id);
    }
}
