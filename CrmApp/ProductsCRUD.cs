using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CrmApp
{
    public class ProductsCRUD
    {

        public static void RunProductsCRUD()
        {
            //Product Manual Data Input
            ProductOption prodOpt = new ProductOption
            {
                ProductName = "Coca-Cola",
                Price = 1.20m,
                Quantity = 4,
            };

            //connect to the db
            using CrmDbContext db = new CrmDbContext(); //to using to xrisomopioume anti gia to dispose (disconnect apo vasi)

            //Create Product
            ProductManagement prodMangr = CreateProduct(prodOpt, db);

            //Read Product
             ReadProduct(prodMangr);

            //Update Product
            UpdateProduct(prodMangr);

            //Delete Product
            DeleteProduct(prodMangr);

        }
        private static ProductManagement CreateProduct(ProductOption prodOpt, CrmDbContext db)
        {
            ProductManagement prodMangr = new ProductManagement(db);
            Product product = prodMangr.CreateProduct(prodOpt);
            Console.WriteLine(
                           $"ProductName={product.ProductName} Price={product.Price} Quantity={product.Quantity} TotalCost={product.TotalCost}");
            return prodMangr;
        }
        private static void ReadProduct(ProductManagement prodMangr)
        {
            Product pr = prodMangr.FindProductById(2);
            if (pr != null)
            {
                Console.WriteLine(
                 $"Id={pr.Id} ProductName={pr.ProductName} Price={pr.Price} Quantity={pr.Quantity} TotalCost={pr.TotalCost}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        private static void UpdateProduct(ProductManagement prodMangr)
        {
            ProductOption prodChangingPrice = new ProductOption
            {

                Price = 5,

            };
            Product cP = prodMangr.Update(prodChangingPrice, 1);
            Console.WriteLine(
                              $"Id= {cP.Id} ProductName= {cP.ProductName} Price= {cP.Price} Quantity = {cP.Quantity}");
        }
        private static void DeleteProduct(ProductManagement prodMangr)
        {
            bool resultP = prodMangr.DeleteProductById(2);
            Console.WriteLine($"Result = {resultP}");
            Product pd2 = prodMangr.FindProductById(2);
            if (pd2 != null)
            {
                Console.WriteLine(
                  $"Id= {pd2.Id} ProductName= {pd2.ProductName} Price= {pd2.Price} Quantity = {pd2.Quantity}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }


    }
}
