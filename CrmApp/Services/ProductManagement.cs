using CrmApp.Options;
using CrmApp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp.Services
{
    public class ProductManagement : IProductManager
    {
        private CrmDbContext db = new CrmDbContext();
        //DB Injection gia na mi to vazoume pantou
        public ProductManagement(CrmDbContext _db)
        {
            db = _db;
        }

        //CRUD
        // create read update delete
        public Product CreateProduct(ProductOption prodOption)
        {
            Product product = new Product
            {
                ProductName = prodOption.ProductName,
                Price = prodOption.Price,
                Quantity = prodOption.Quantity,
            };

            //db.Database.EnsureCreated();
            db.Products.Add(product);
            db.SaveChanges();

            return product;
        }

        public Product FindProductById(int id)
        {
            Product product = db.Products.Find(id);
            return product;
        }

        public Product Update(ProductOption prodOption, int productId)
        {

            Product product = db.Products.Find(productId);

            if (prodOption.ProductName != null)
                product.ProductName = prodOption.ProductName;
            if (prodOption.Price != 0)
                product.Price = prodOption.Price;
            if (prodOption.Quantity != 0)
                product.Quantity = prodOption.Quantity;

            db.SaveChanges();
            return product;
        }

        public bool HardDeleteProductById(int id)
        {

            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Product> GetAllProducts()
        {
            return db.Products
                .ToList();
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
    }
}
