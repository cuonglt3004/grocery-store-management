using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Customer>? Customer { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<CustomerPoint>? CustomerPoint { get; set; }
        public DbSet<Order>? Order { get; set; }
        public DbSet<OrderDetail>? OrderDetail { get; set; }
        public DbSet<Product>? Product { get; set; }
        public DbSet<Promotion>? Promotion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerPoint>()
            .HasOne(x => x.Order).WithMany(x => x.CustomerPoints).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CustomerPoint>()
            .HasOne(x => x.Customer).WithMany(x => x.CustomerPoints).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderDetail>()
            .HasOne(x => x.Order).WithMany(x => x.OrderDetails).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderDetail>()
            .HasOne(x => x.Product).WithMany(x => x.OrderDetails).OnDelete(DeleteBehavior.NoAction);
        }
    }

}