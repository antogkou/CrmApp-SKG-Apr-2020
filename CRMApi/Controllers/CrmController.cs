using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmApp;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRMApi.Controllers
{
    [ApiController]
    //controller=crm apo launchSettings
    [Route("[controller]/customer")]

    public class CrmController : ControllerBase
    {
        private readonly ILogger<CrmController> _logger;

        public CrmController(ILogger<CrmController> logger)
        {
            _logger = logger;
        }

        //starting endpoint
        [HttpGet]
        public string Get()
        {

            return "Welcome to our customers";
        }

        //GET ALL CUSTOMERS
        [HttpGet("all")]
        public List<Customer> GetAllCustomers()
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.GetAllCustomers();
                //db.Customers.ToList();
        }

        //GET CUSTOMER BY /ID
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.FindCustomerById(id);
        }

        //POST CUSTOMER (new)
        [HttpPost("")]
        public Customer PostCustomer(CustomerOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.CreateCustomer(custOpt);

        }

        //PUT CUSTOMER (update entries)
        [HttpPut("{id}")]
        public Customer PutCustomer(int id, CustomerOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.Update(custOpt, id);
        }

        //DELETE Customer
        [HttpDelete("hard/{id}")]
        public bool HardDeleteCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.HardDeleteCustomerById(id);
        }

        //PUT isActive=0
        [HttpPut("disable/{id}")]
        public bool DisableCustomerById(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.DisableCustomerById(id);
        }

        //PUT isActive=1
        [HttpPut("enable/{id}")]
        public bool EnableCustomerById(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.EnableCustomerById(id);
        }

        //-----------------------------------------------------------------//
        
    }
}
