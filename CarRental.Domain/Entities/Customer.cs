using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string DriverLicenseNumber {  get; set; }
        public required string ContactInformation { get; set; }

        // Navigation properties
        public ICollection<RentalBooking> RentalBookings { get; set; } = new List<RentalBooking>();

    }
}
