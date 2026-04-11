using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class VehicleReturnConfigurations : IEntityTypeConfiguration<VehicleReturn>
    {
        public void Configure(EntityTypeBuilder<VehicleReturn> builder)
        {
            builder.ToTable("VehicleReturns");
            builder.HasKey(vr => vr.Id);
            builder.Property(vr => vr.Id).ValueGeneratedOnAdd();
            builder.Property(vr => vr.ActualReturnDate).HasColumnType("datetime").IsRequired(false);
            builder.Property(vr => vr.ActualRentalDays).HasColumnType("tinyint").IsRequired(false);
            builder.Property(vr => vr.Mileage).HasColumnType("smallint").IsRequired(false);
            builder.Property(vr => vr.ConsumedMilaeage).HasColumnType("smallint").IsRequired(false);
            builder.Property(vr => vr.FinalCheckNotes).HasColumnType("nvarchar").HasMaxLength(500).IsRequired(false);
            builder.Property(vr => vr.AdditionalCharges).HasColumnType("smallmoney").HasMaxLength(500).IsRequired(false);
            builder.Property(vr => vr.ActualTotalDueAmount).HasColumnType("smallmoney").HasMaxLength(500).IsRequired(false);
        }
    }
}
