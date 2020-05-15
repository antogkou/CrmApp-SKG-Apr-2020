using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmApp;
using CrmApp.Options;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmMVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager prodMan;

        public ProductController(IProductManager _prodMan)
        {
            prodMan = _prodMan;
        }

        //GET ALL PRODUCTS
        public List<Product> GetAll()
        {
            return prodMan.GetAll();
        }


        //addproduct
        //[HttpPost]
        //public Product AddProduct([FromBody] ProductOption prodOpt)
        //{
        //    return prodOpt.CreateProduct(prodOpt);
        //}
    }
}