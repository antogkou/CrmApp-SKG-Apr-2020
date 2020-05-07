using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CrmApp
{
    class MainProgram
    {
        static void Main()
        { 
            RunCustomers.RunDBCustomers();  //Use the customer's class function
            RunProducts.RunDBProducts(); //Use the product's class function
        }
    }
}