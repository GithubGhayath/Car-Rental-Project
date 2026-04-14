using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class RentalBooking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime RentalStartDate {  get; set; }
        public DateTime? RentalEndDate {  get; set; }
        public required string PickupLocation { get; set; }
        public required string DropoffLocation { get; set; } 
        public byte InitialRentalDays { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public decimal InitialTotalDueAmount { get; set; }
        public required string IntialCheckNotes { get; set; }


        // Navigation properties
        public required Customer Customer { get; set; }
        public required Vehicle Vehicle { get; set; }    

        public RentalTransaction? Transaction { get; set; }

    }
}
