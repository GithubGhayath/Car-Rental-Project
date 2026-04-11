using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public required string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public decimal Cost { get; set; }

        // Navigation properties
        public required Vehicle Vehicle { get; set; }
    }
}
