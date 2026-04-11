using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class VehicleReturn
    {
        public int Id { get; set; }
        public DateTime ActualReturnDate { get;set; }
        public DateTime ActualRentalDays { get;set; }
        public int Mileage { get; set; }
        public int ConsumedMilaeage { get; set; }
        public required string FinalCheckNotes { get; set; }
        public decimal AdditionalCharges { get; set; }
        public decimal ActualTotalDueAmount { get; set; }

        public required RentalTransaction RentalTransaction { get; set; }
    }
}
