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
    //controller=Customer apo to CustomerController
    [Route("[controller]")]

    public class CustomerController : ControllerBase
    {

        //injection
        private CrmDbContext db = new CrmDbContext();
      

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerManager custMangr;

        public CustomerController(ILogger<CustomerController> logger, ICustomerManager _custMangr)
        {
            _logger = logger;
            custMangr = _custMangr;
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
            return custMangr.GetAllCustomers();
                //db.Customers.ToList();
        }

        //GET CUSTOMER BY /ID
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
           
            return custMangr.FindCustomerById(id);
        }

        //POST CUSTOMER (new)
        [HttpPost("")]
        public Customer PostCustomer([FromForm] CustomerOption custOpt)
        {
            return custMangr.CreateCustomer(custOpt);
        }

        //PUT CUSTOMER (update entries)
        [HttpPut("{id}")]
        public Customer PutCustomer(int id, CustomerOption custOpt)
        {
            return custMangr.Update(custOpt, id);
        }

        //DELETE Customer
        [HttpDelete("hard/{id}")]
        public bool HardDeleteCustomer(int id)
        {
            return custMangr.HardDeleteCustomerById(id);
        }

        //PUT isActive=0
        [HttpPut("disable/{id}")]
        public bool DisableCustomerById(int id)
        {
            return custMangr.DisableCustomerById(id);
        }

        //PUT isActive=1
        [HttpPut("enable/{id}")]
        public bool EnableCustomerById(int id)
        {
            return custMangr.EnableCustomerById(id);
        }    
    }
}
