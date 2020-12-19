using DataAccessHomework.Entities.Concrete;
using DataAccessProjects.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProjects.Context
{
    public class ProjectContext : DbContext
    {

        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=LAPTOP-Q5UKAJQO ;Database=DataAccessProject2;Integrated Security=True";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
