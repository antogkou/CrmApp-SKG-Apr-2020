using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;

namespace CrmApp
{
    class CustomersCRUD
    {
        public static void RunCustomersCRUD()
        {
            //CustomerDataInput
            CustomerOption custOpt = new CustomerOption
            {
                FirstName = "Antonis",
                LastName = "Gkoutzamanmis",
                Address = "Thessaloniki",
                Email = "agkoutzamanis@athtech.gr",
                Dob = new DateTime(1992, 8, 4, 6, 00, 0),
            };

            //connect to the DB
            using CrmDbContext db = new CrmDbContext();
            //to using to xrisomopioume anti gia to dispose (disconnect apo vasi)

            //create a customer
            CustomerManagement custMangr = new CustomerManagement(db);
            Customer customer = custMangr.CreateCustomer(custOpt);
            Console.WriteLine(
                        $"Id= {customer.Id} Name={customer.FirstName} Address={customer.Address} Dob={customer.Dob.Date.Day + "/"}{customer.Dob.Date.Month + "/"}{customer.Dob.Date.Year}");


            //Read Customer
            Customer cx = custMangr.FindCustomerById(2);
            if (cx != null)
            {
                Console.WriteLine(
                 $"Id={cx.Id} Name={cx.FirstName} Address={cx.Address} Dob={cx.Dob}");
            }
            else
            {
                Console.WriteLine("Customer Not Found");
            }

            //Update Customer
            CustomerOption custChangingAddress = new CustomerOption
            {

                Address = "Lamia",

            };
            Customer c2 = custMangr.Update(custChangingAddress, 1);
            Console.WriteLine(
                             $"Id= {c2.Id} Name= {c2.FirstName} Address= {c2.Address}");

            //Delete Customer
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
                Console.WriteLine("Customer Not Found");
            }
        }
    }
}
