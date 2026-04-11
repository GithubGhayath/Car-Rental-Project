using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class RentalTransactionConfigurations : IEntityTypeConfiguration<RentalTransaction>
    {
        public void Configure(EntityTypeBuilder<RentalTransaction> builder)
        {
            builder.ToTable("RentalTransactions");
            builder.HasKey(rt => rt.Id);
            builder.Property(rt => rt.Id).ValueGeneratedOnAdd();
            builder.Property(rt => rt.PaymentDetails).HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired(true);
            builder.Property(rt => rt.PaidInitialTotalDueAmount).HasColumnType("smallmoney").IsRequired(true);
            builder.Property(rt => rt.ActualTotalDueAmount).HasColumnType("smallmoney").IsRequired(true);
            builder.Property(rt => rt.TotalRemaining).HasColumnType("smallmoney").IsRequired(false);
            builder.Property(rt => rt.TotalRefundedAmount).HasColumnType("smallmoney").IsRequired(false);
            builder.Property(rt => rt.TransactionDate).HasColumnType("datetime").IsRequired(true);
            builder.Property(rt => rt.UpdatedTransactionDate).HasColumnType("datetime").IsRequired(false);

            builder.HasOne(rt=>rt.RentalBooking).WithOne(rb=>rb.Transaction).HasForeignKey<RentalTransaction>(rt=>rt.RentalBookingId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(rt=>rt.VehicleReturn).WithOne(rb=>rb.RentalTransaction).HasForeignKey<RentalTransaction>(rt=>rt.VehicleReturnId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
