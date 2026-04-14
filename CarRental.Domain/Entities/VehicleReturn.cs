using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class VehicleReturn
    {
        public int Id { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public byte? ActualRentalDays { get; set; }
        public short? Mileage { get; set; }
        public short? ConsumedMilaeage { get; set; }
        public string? FinalCheckNotes { get; set; }
        public decimal? AdditionalCharges { get; set; }
        public decimal? ActualTotalDueAmount { get; set; }

        public required RentalTransaction RentalTransaction { get; set; }
    }
}
