using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class VehicleConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).ValueGeneratedOnAdd();
            builder.Property(v => v.Make).HasColumnType("NVARCHAR").HasMaxLength(50).IsRequired(true);
            builder.Property(v => v.Model).HasColumnType("NVARCHAR").HasMaxLength(50).IsRequired(true);
            builder.Property(v => v.PlateNumber).HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired(true);
            builder.Property(v => v.RentalPricePerDay).HasColumnType("decimal").IsRequired(true);
            builder.Property(v => v.IsAvailable).HasColumnType("bit").IsRequired(true);
            builder.Property(v => v.Year).HasColumnType("INT").IsRequired(true);
            builder.Property(v => v.Mileage).HasColumnType("INT").IsRequired(false);

            builder.HasOne(v=>v.FuleType).WithMany(f=>f.Vehicles).HasForeignKey(v=>v.FuleTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(v=>v.VehicleCategory).WithMany(vc=>vc.Vehicles).HasForeignKey(v=>v.VehicleCategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
