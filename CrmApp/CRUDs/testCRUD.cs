using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class testCRUD
    {
        public static void RunTestCRUD()
        {
            CustomerOption custOpt = new CustomerOption
            {
                FirstName = "Maria",
                LastName = "Pentagiotissa",
                Address = "Athens",
                Email = "maria@gmail.com",

            };

            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);


            // testing the creation of a customer
            Customer customer = custMangr.CreateCustomer(custOpt);
            Console.WriteLine(
                $"Id= {customer.Id} Name= {customer.FirstName} Address= {customer.Address}");


            //testing reading a customer
            customer = custMangr.FindCustomerById(2);
            if (customer != null)
                Console.WriteLine(
                    $"Id= {customer.Id} Name= {customer.FirstName} Address= {customer.Address}");


            //testing updating
            CustomerOption custChangingAddress = new CustomerOption
            {
                Address = "Lamia"
            };
            customer = custMangr.Update(custChangingAddress, 1);
            Console.WriteLine(
                $"Id= {customer.Id} Name= {customer.FirstName} Address= {customer.Address}");


            //testing deletion

            bool result = custMangr.HardDeleteCustomerById(2);
            Console.WriteLine($"Result = {result}");
            customer = custMangr.FindCustomerById(2);
            if (customer != null)
            {
                Console.WriteLine(
                $"Id= {customer.Id} Name= {customer.FirstName} Address= {customer.Address}");

            }
            else
            {
                Console.WriteLine("not found");
            }

            //---------------------------------------//
            ProductOption prOpt = new ProductOption
            {
                ProductName = "mila",
                Price = 1.20m,
                Quantity = 10
            };

            ProductManagement prodMangr = new ProductManagement(db);

            Product product = prodMangr.CreateProduct(prOpt);

            BasketManagement baskMangr = new BasketManagement(db);

            BasketOption baskOption = new BasketOption
            {
                CustomerId = 1
            };

            Basket basket = baskMangr.CreateBasket(baskOption);
            BasketProductOption bskProdOpt = new BasketProductOption
            {
                BasketId = basket.Id,
                ProductId = 1
            };

            BasketProduct baskProd = baskMangr.AddProduct(bskProdOpt);
            basket.BasketProducts.ForEach(p =>
               Console.WriteLine(p.Product.ProductName));
            

            //baskProd.Basket.BasketProducts.ForEach(p =>
            //   Console.WriteLine(p.Product.ProductName));
        }
    }
}
