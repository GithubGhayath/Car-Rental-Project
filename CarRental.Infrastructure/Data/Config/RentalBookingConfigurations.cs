using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class RentalBookingConfigurations : IEntityTypeConfiguration<RentalBooking>
    {
        public void Configure(EntityTypeBuilder<RentalBooking> builder)
        {
            builder.ToTable("RentalBookings");
            builder.HasKey(rb => rb.Id);
            builder.Property(rb => rb.Id).ValueGeneratedOnAdd();
            builder.Property(rb => rb.PickupLocation).HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired(true);
            builder.Property(rb => rb.DropoffLocation).HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired(true);
            builder.Property(rb => rb.IntialCheckNotes).HasColumnType("NVARCHAR").HasMaxLength(500).IsRequired(true);
            builder.Property(rb => rb.InitialTotalDueAmount).HasColumnType("smallmoney").IsRequired(true);
            builder.Property(rb => rb.RentalPricePerDay).HasColumnType("smallmoney").IsRequired(true);
            builder.Property(rb => rb.InitialRentalDays).HasColumnType("tinyint").IsRequired(true);
            builder.Property(rb => rb.RentalStartDate).HasColumnType("date").IsRequired(true); 
            builder.Property(rb => rb.RentalEndDate).HasColumnType("date").IsRequired(false);

            builder.HasOne(rb => rb.Customer).WithMany(c => c.RentalBookings).HasForeignKey(rb => rb.CustomerId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(rb => rb.Vehicle).WithMany(v => v.RentalBookings).HasForeignKey(rb => rb.VehicleId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
