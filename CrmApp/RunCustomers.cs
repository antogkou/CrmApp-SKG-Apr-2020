using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class RunCustomers
    {
        public static void RunDBCustomers()
        {
            //CustomerDataInput
            CustomerOption custOpt = new CustomerOption
            {
                FirstName = "Antonis",
                LastName = "Gkoutzamanmis",
                Address = "Thessaloniki",
                Email = "agkoutzamanis@athtech.gr",

            };

            //connect to the db
            using CrmDbContext db = new CrmDbContext();
            //to using to xrisomopioume anti gia to dispose (disconnect apo vasi)

            //create a customer
            CustomerManagement custMangr = new CustomerManagement(db);
            Customer customer = custMangr.CreateCustomer(custOpt);
            Console.WriteLine(
                        $"Id= {customer.Id} Name= {customer.FirstName} Address= {customer.Address}");


            //testing reading a customer
            Customer cx = custMangr.FindCustomerById(2);
            if (cx != null)
            {
                Console.WriteLine(
                 $"Id= {cx.Id} Name= {cx.FirstName} Address= {cx.Address}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            //testing updating customer
            CustomerOption custChangingAddress = new CustomerOption
            {

                Address = "Lamia",

            };
            Customer c2 = custMangr.Update(custChangingAddress, 1);
            Console.WriteLine(
                             $"Id= {c2.Id} Name= {c2.FirstName} Address= {c2.Address}");

            //testing customer deletion 
            bool result = custMangr.DeleteCustomerById(2);
            Console.WriteLine($"Result = {result}");
            Customer cx2 = custMangr.FindCustomerById(2);
            if (cx2 != null)
            {
                Console.WriteLine(
                $"Id= {c2.Id} Name= {c2.FirstName} Address= {c2.Address}");
            }
            else
            {
                Console.WriteLine("Customer Not Found");
            }
        }
    }
}
