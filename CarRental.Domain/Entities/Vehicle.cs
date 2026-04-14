using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public int? Mileage { get; set; }
        public int FuleTypeId { get; set; }
        public required string PlateNumber { get; set; }
        public int VehicleCategoryId { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        // Navigation properties
        public required FuleType FuleType { get; set; }
        public ICollection<Maintenance> Maintenances {  get; set; }=new List<Maintenance>();
        public ICollection<RentalBooking> RentalBookings { get; set; } = new List<RentalBooking>();
        public required VehicleCategory VehicleCategory { get; set; }
    }
}
