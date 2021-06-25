using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Models;

namespace TestWeek6.Context
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer").HasKey(k => k.CF);
            builder.Property(c => c.CF).IsFixedLength().HasMaxLength(16);
            builder.Property(n => n.Name).HasMaxLength(20).IsRequired();
            builder.Property(s => s.Surname).HasMaxLength(20).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(50).IsRequired();

            
        }
    }
}
