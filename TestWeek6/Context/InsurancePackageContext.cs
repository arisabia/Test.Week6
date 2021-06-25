using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Models;

namespace TestWeek6.Context
{
    public class InsurancePackageContext : DbContext
    {
        public DbSet<Insurance> Insuraces { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public InsurancePackageContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                        Initial Catalog= InsurancePackage; Server = .\SQLEXPRESS");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Insurance>(new InsuranceConfiguration());
            modelBuilder.ApplyConfiguration<Customer>(new CustomerConfiguration());
        }
       }
}
