using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasColumnType("NVARCHAAR").HasMaxLength(100).IsRequired(true);
            builder.Property(c => c.ContactInformation).HasColumnType("NVARCHAAR").HasMaxLength(100).IsRequired(true);
            builder.Property(c => c.DriverLicenseNumber).HasColumnType("NVARCHAAR").HasMaxLength(20).IsRequired(true);
        }
    }
}
