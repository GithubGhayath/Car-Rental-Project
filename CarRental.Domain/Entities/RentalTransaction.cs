using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class RentalTransaction
    {
        public int Id { get; set; }
        public int RentalBookingId { get; set; }
        public int VehicleReturnId { get; set; }
        public required string PaymentDetails { get; set; }
        public decimal PaidInitialTotalDueAmount { get; set; }
        public decimal ActualTotalDueAmount { get; set; }
        public decimal? TotalRemaining {  get; set; }
        public decimal? TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate {  get; set; }

        public required RentalBooking RentalBooking { get; set; }

        public required VehicleReturn VehicleReturn { get; set; }
    }
}
