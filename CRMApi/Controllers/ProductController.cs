
using System.Collections.Generic;
using CrmApp;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRMApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        //injection
        private CrmDbContext db = new CrmDbContext();

        private readonly ILogger<ProductController> _logger;
        private readonly IProductManager prodMangr;

        public ProductController(ILogger<ProductController> logger, IProductManager _prodMangr)
        {
            _logger = logger;
            prodMangr = _prodMangr;
        }

        //starting endpoint
        [HttpGet]
        public string Get()
        {
            return "Welcome to our products";
        }

        //GET ALL PRODUCTS
        [HttpGet("all")]
        public List<Product> GetAllProducts()
        {
            return prodMangr.GetAllProducts();
            //db.Customers.ToList();
        }

        //GET PRODUCT BY /ID
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return prodMangr.FindProductById(id);
        }

        //POST PRODUCT (new)
        [HttpPost("")]
        public Product PostProduct(ProductOption prodOpt)
        {
            return prodMangr.CreateProduct(prodOpt);

        }

        //PUT PRODUCT (update entries)
        [HttpPut("{id}")]
        public Product PutProduct(int id, ProductOption custOpt)
        {
            return prodMangr.Update(custOpt, id);
        }

        //DELETE PRODUCT
        [HttpDelete("{id}")]
        public bool HardDeleteProduct(int id)
        {
            return prodMangr.HardDeleteProductById(id);
        }
    }
}