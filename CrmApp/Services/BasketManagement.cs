using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp.Services
{
    public class BasketManagement
    {

        private CrmDbContext db = new CrmDbContext();
        public BasketManagement(CrmDbContext _db)
        {
            db = _db;
        }

        //Create Basket
        public Basket CreateBasket(BasketOption baskOption)
        {
            CustomerManagement castMangr = new CustomerManagement(db);
            Basket basket = new Basket
            {
               Customer=castMangr.FindCustomerById(baskOption.CustomerId)
                
            };

          //  db.Database.EnsureCreated();
            db.Baskets.Add(basket);
            db.SaveChanges();
            return basket;
        }

        //Add Product to the Basket
        public BasketProduct AddProduct(BasketProductOption bskProd)
        {
            BasketProduct basketProduct = new BasketProduct
            {
                Basket = db.Baskets.Find(bskProd.BasketId),
                Product = db.Products.Find(bskProd.ProductId)
            };

            //db.Database.EnsureCreated();
            db.BasketProducts.Add(basketProduct);
            db.SaveChanges();
            return basketProduct;
        }

        //FindBasketById
        public Basket FindBasketById(int basketId)
        {
            return db.Baskets.Find(basketId);
        }

        //FindCustomerBaskets
        public List<Basket> FindCustomerBaskets(int custId)
        {
            return db.Baskets
                .Where(basket => basket.Customer.Id == custId)
                .ToList();
        }

        //DeleteProductFromBasket
        public bool DeleteProduct(BasketProductOption bskProdOpt)
        {

            BasketProduct bskProd = db.BasketProducts.Find(bskProdOpt);

            if (bskProd != null)
            {
                db.BasketProducts.Remove(bskProd);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        
    }
}
