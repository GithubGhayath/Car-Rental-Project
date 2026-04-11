using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FuleType> FuleTypes { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<RentalBooking> RentalBookings {  get; set; }
        public DbSet<RentalTransaction> RentalTransactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleReturn> VehicleReturns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

    }
}
