using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;

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
        }
    }
}