using CarRental.Application.Repositories.Common;
using CarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Repositories
{
    public interface IVehicleRepository:IRepository<Vehicle>
    {
        void Update(Vehicle entity);
    }

}
