using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public  class VehicleCategoryRepository:Repository<VehicleCategory>,IVehicleCategoryRepository
    {
        private readonly AppDbContext _Context;
         public VehicleCategoryRepository(AppDbContext context) :base(context)
        {
            _Context = context;
        }

        public void Update(VehicleCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
