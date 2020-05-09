using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmApp;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRMApi.Controllers
{
    
    [ApiController]
    [Route("crm/product")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
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
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMngr = new ProductManagement(db);
            return prodMngr.GetAllProducts();
            //db.Customers.ToList();
        }

        //GET PRODUCT BY /ID
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMngr = new ProductManagement(db);
            return prodMngr.FindProductById(id);
        }

        //POST PRODUCT (new)
        [HttpPost("")]
        public Product PostProduct(ProductOption prodOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMngr = new ProductManagement(db);
            return prodMngr.CreateProduct(prodOpt);

        }

        //PUT PRODUCT (update entries)
        [HttpPut("{id}")]
        public Product PutProduct(int id, ProductOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMngr = new ProductManagement(db);
            return prodMngr.Update(custOpt, id);
        }

        //DELETE PRODUCT
        [HttpDelete("{id}")]
        public bool HardDeleteProduct(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMngr = new ProductManagement(db);
            return prodMngr.HardDeleteProductById(id);
        }
    }
}