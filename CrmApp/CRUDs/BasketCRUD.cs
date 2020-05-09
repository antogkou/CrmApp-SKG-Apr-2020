using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class BasketCRUD {
        public static void RunBasketCRUD()
        {
            //connect to the DB
            using CrmDbContext db = new CrmDbContext();
            //to using to xrisomopioume anti gia to dispose (disconnect apo vasi)

            ProductOption prOpt = new ProductOption
            {
                ProductName = "apples",
                Price = 1.20m,
                Quantity = 10
            };

            ProductManagement prodMangr = new ProductManagement(db);

            Product product = prodMangr.CreateProduct(prOpt);

            BasketManagement baskMangr = new BasketManagement(db);

            BasketOption baskOption = new BasketOption
            {
                CustomerId = 3
            };

            Basket basket = baskMangr.CreateBasket(baskOption);
            BasketProductOption bskProdOpt = new BasketProductOption
            {
                BasketId = basket.Id,
                ProductId = 1
            };


            BasketProduct baskProd = baskMangr.AddProduct(bskProdOpt);

            //Console.WriteLine(basket.BasketProducts[0], Product.ProductName);

                basket.BasketProducts.ForEach(p =>
               Console.WriteLine(p.Product.ProductName));
            
        }
    }
}
