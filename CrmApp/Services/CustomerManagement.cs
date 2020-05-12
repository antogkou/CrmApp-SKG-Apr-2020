using CrmApp.Options;
using CrmApp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp.Services
{
    public class CustomerManagement : ICustomerManager
    {
        
        private CrmDbContext db;
        //DB Injection gia na mi to vazoume pantou
        public CustomerManagement(CrmDbContext _db)
        {
            db = _db;
        }

        //CRUD
        // create read update delete
        public Customer CreateCustomer(CustomerOption custOption)
        {
            Customer customer = new Customer
            {
                FirstName = custOption.FirstName,
                LastName = custOption.LastName,
                Address = custOption.Address,
                Dob = custOption.Dob,
                Email = custOption.Email,
                IsActive = true,
                Balance = 0,
            };

           //if db doesnt exist, create it
            //db.Database.EnsureCreated();

            db.Customers.Add(customer);
            db.SaveChanges();

            return customer;
        }

        public Customer FindCustomerById(int customerId)
        {
            return db.Customers.Find(customerId); ;
        }

        public List<Customer> FindCustomerByName(CustomerOption custOption)
        {
            return db.Customers
                .Where(cust => cust.LastName == custOption.LastName)// && cust.FirstName == custOption.FirstName
                .Where(cust => cust.FirstName == custOption.FirstName)
                .ToList();

        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers
                .ToList();
        }

        public Customer Update(CustomerOption custOption, int customerId)
        {

            Customer customer = db.Customers.Find(customerId);

            if (custOption.FirstName != null)
                customer.FirstName = custOption.FirstName;
            if (custOption.LastName != null)
                customer.LastName = custOption.LastName;
            if (custOption.Email != null)
                customer.Email = custOption.Email;
            if (custOption.Address != null)
                customer.Address = custOption.Address;

            db.SaveChanges();
            return customer;
        }

        public bool HardDeleteCustomerById(int id)
        {

            Customer customer = db.Customers.Find(id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        //isActive=0
        public bool EnableCustomerById(int id)
        {

            Customer customer = db.Customers.Find(id);
            if (customer != null)
            {
                customer.IsActive = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        //isActive=1
        public bool DisableCustomerById(int id)
        {

            Customer customer = db.Customers.Find(id);
            if (customer != null)
            {
                customer.IsActive = false;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Customer GetCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public Customer PostCustomer(CustomerOption custOpt)
        {
            throw new System.NotImplementedException();
        }

        public Customer PutCustomer(int id, CustomerOption custOpt)
        {
            throw new System.NotImplementedException();
        }

        public bool HardDeleteCustomer(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}