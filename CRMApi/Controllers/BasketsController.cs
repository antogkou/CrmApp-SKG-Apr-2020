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
        private readonly IBasketManager baskMangr;
        public BasketsController(ILogger<BasketsController> logger, IBasketManager _baskMangr)
        {
            _logger = logger;
            baskMangr = _baskMangr;
        }

        //starting endpoint
        [HttpGet]
        public string Get()
        {
            return "Welcome to our baskets";
        }


        //POST   
        [HttpPost("{customerId}/basket")]
        public Basket CreateBasket(int customerId)
        {
            BasketOption bskOption = new BasketOption
            {
                CustomerId = customerId
            };

            return baskMangr.CreateBasket(bskOption);
        }

        //POST
        [HttpPost("basket/{basketId}/product/{productId}")]
        public BasketProduct AddToBasket(int basketId, int productId)
        {
            BasketProductOption bskProd = new BasketProductOption
            {
                BasketId = basketId,
                ProductId = productId
            };

            return baskMangr.AddProduct(bskProd);
        }

        [HttpGet("basket/{basketId}")]
        public List<Basket> GetCustomerBaskets(int basketId)
        {
            return baskMangr.FindCustomerBaskets(basketId);
        }

        [HttpGet("basketproducts/{basketId}")]
        public List<int> GetAllBasketProducts(int basketId)
        {
            return baskMangr.FindCustomerBasketProducts(basketId);
        }
    }
}
