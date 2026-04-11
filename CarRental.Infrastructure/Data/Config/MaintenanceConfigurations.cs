using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class MaintenanceConfigurations : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.ToTable("Maintenances");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Description).HasColumnType("NVARCHAR").HasMaxLength(300).IsRequired(true);
            builder.Property(m => m.MaintenanceDate).HasColumnType("date").IsRequired(true);
            builder.Property(m => m.Cost).HasColumnType("decimal(18,2)").IsRequired(true);

            builder.HasOne(m => m.Vehicle).WithMany(v => v.Maintenances).HasForeignKey(m => m.VehicleId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
