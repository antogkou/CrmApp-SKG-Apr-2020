using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            //Call UI MENU
            Ui.Menu();

            // RunCustomers.RunDBCustomers();  //Use the customer's class function
            // RunProducts.RunDBProducts(); //Use the product's class function

            //test find
            //using CrmDbContext db = new CrmDbContext();
            //BasketManagement baskMangr = new BasketManagement(db);
            //Basket basket = baskMangr.FindBasketById(1);

            //basket.BasketProducts.ForEach(baskProduct =>
            //Console.WriteLine(
            //    db.BasketProducts
            //.Include(b => b.Product)
            //.Where(b => b.Id == baskProduct.Id)
            //.First().Product
            //.ProductName
            //)
            //    );

        }
    }
}