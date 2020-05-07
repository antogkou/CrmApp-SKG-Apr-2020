using CrmApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Repository
{
    public class CrmDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketProducts> BasketProducts { get; set; }

        private readonly string connectionString =
             "Server=localhost; " +
            "Database=sql1; " +
            "User Id=sa; " +
            "Password=admin!@#123;";

        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }


    }
 }
