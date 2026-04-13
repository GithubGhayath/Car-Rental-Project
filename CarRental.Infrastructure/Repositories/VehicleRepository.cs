using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class VehicleRepository:Repository<Vehicle>,IVehicleRepository
    {
        private readonly AppDbContext _Context;
        public VehicleRepository(AppDbContext context):base(context)
        {
            _Context = context;
        }

        public void Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
