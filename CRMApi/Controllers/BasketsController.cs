using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CrmApp;
using CrmApp.Repository;
using Microsoft.Extensions.Logging;
using CrmApp.Services;
using CrmApp.Options;
using CrmApp.Models;
using System.Net;

namespace CRMApi.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        //injection
        private CrmDbContext db = new CrmDbContext();


        private readonly ILogger<BasketsController> _logger;

        public BasketsController(ILogger<BasketsController> logger)
        {
            _logger = logger;
        }

        //starting endpoint
        [HttpGet]
        public string Get()
        {
            return "Welcome to our baskets";
        }

        //GET CUSTOMER BY /ID
        //[HttpGet("{id}")]
        //public List<Basket> GetBasket(int b_id)
        //{
        //    using CrmDbContext db = new CrmDbContext();
        //    BasketManagement basktMangr = new BasketManagement(db);
        //    return basktMangr.FindCustomerBaskets(b_id);
        //}

        ////GET ALL BASKETS
        //[HttpGet("all")]
        //public List<Basket> GetAllBaskets()
        //{
        //    using CrmDbContext db = new CrmDbContext();
        //    BasketManagement bsktMangr = new BasketManagement(db);
        //    return bsktMangr.GetAllBaskets();
        //db.Customers.ToList();

        //POST    /basket/customer/{id}

        //[HttpPost("create/{id}")]
        //public Basket CreateBasket(BasketOption bskprodOpt)
        //{
        //    using CrmDbContext db = new CrmDbContext();
        //    BasketManagement bsktMngr = new BasketManagement(db);
        //    return bsktMngr.CreateBasket(bskprodOpt);
        //}

        //GET CUSTOMER's Basket BY /ID
        [HttpGet("{basket_id}/{id}")]
        public Customer GetCustomer(int cust_id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.FindCustomerById(cust_id);
        }

       
        //POST   
        [HttpPost("basket/{basketId}/product//{productId}")]
        public BasketProduct AddToBasket(int basketId, int productId)
        {
            BasketProductOption bskProd = new BasketProductOption

           
        }
    }
}
