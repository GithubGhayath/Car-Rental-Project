using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class FuleType 
    {
        public int Id { get; set; }
        public required string Type { get; set; } 

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
