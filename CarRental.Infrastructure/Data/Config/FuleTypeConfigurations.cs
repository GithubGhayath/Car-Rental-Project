using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data.Config
{
    public class FuleTypeConfigurations : IEntityTypeConfiguration<FuleType>
    {
        public void Configure(EntityTypeBuilder<FuleType> builder)
        {
            builder.ToTable("FuleTypes");
            builder.HasKey(ft => ft.Id);
            builder.Property(ft=> ft.Id).ValueGeneratedOnAdd();
            builder.Property(ft => ft.Type).HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired(true);
        }
    }
}
