using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TitanHelp.Models;

namespace TitanHelp.Data
{
    public class TitanHelpContext : DbContext
    {
        public TitanHelpContext (DbContextOptions<TitanHelpContext> options)
            : base(options)
        {
        }

        //public DbSet<TitanHelp.Models.Customer> Customer { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
