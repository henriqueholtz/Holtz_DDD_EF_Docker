using Holtz_DDD_EF_Docker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Infraestructure.Data
{
    public class ApplicationContext : DbContext
    {
        private const string CREATED_DATE = "CreatedDate";
        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(CREATED_DATE) != null)) {
                
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Property(CREATED_DATE).CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property(CREATED_DATE).IsModified = false;
                        break;
                }
            }
            return base.SaveChanges();
        }
    }
}
