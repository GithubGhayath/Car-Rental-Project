using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class VehicleReturnRepository:Repository<VehicleReturn>, IVehicleReturnRepository
    {
        private readonly AppDbContext _Context;
        public VehicleReturnRepository(AppDbContext context) : base(context)
        {
            _Context = context;
        }

        public void Update(VehicleReturn entity)
        {
            throw new NotImplementedException();
        }
    }
}
