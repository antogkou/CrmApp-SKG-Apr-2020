using System.Linq;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            var dbContext = new CrmAppDbContext();
            //dbContext.Database.EnsureCreated();

            // Insert
            var customer = new Customer()
            {
                Name = "Unknown customer",
                Sex = 0
            };

            dbContext.Add(customer);
            dbContext.SaveChanges();

            // Select
            var customers = dbContext
                .Set<Customer>()
                .Where(cust => cust.CustomerId == 1)
                .SingleOrDefault();

            // Remove
            //dbContext.RemoveRange(customers);
            //dbContext.SaveChanges();
        }
    }
}
