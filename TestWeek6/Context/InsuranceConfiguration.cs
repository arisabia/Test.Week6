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
    public class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("Insurance").HasKey(k => k.Number);
            builder.Property(d => d.InitialContractDate).HasColumnType("datetime2").IsRequired();
            builder.Property(c => c.InsurenceCoverage).IsRequired();
            builder.Property(m => m.MonthlyPayment).IsRequired();

            builder.HasOne(c => c.Customer)
                    .WithMany(i => i.Insurances)
                    .HasForeignKey(k => k.CustomerCF);

            builder.HasDiscriminator<string>("isurance_type")
                        .HasValue<CarInsurance>("car")
                        .HasValue<LifeInsurance>("life")
                        .HasValue<TheftPolicy>("theft");
        }
    }
}
