using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class VehicleCategoryConfigurations : IEntityTypeConfiguration<VehicleCategory>
    {
        public void Configure(EntityTypeBuilder<VehicleCategory> builder)
        {
            builder.ToTable("VehicleCategories");
            builder.HasKey(vc => vc.Id);
            builder.Property(vc => vc.Id).ValueGeneratedOnAdd();
            builder.Property(vc => vc.CategoryName).HasColumnType("NVARCHAR").HasMaxLength(50).IsRequired(true);
        }
    }
}
