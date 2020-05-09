using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrmApp;
using CrmApp.Repository;
using Microsoft.Extensions.Logging;
using CrmApp.Services;

namespace CRMApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
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
        [HttpGet("{id}")]
        public List<Basket> GetBasket(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            BasketManagement basktMangr = new BasketManagement(db);
            return basktMangr.FindCustomerBaskets(id);
        }




    }
}
