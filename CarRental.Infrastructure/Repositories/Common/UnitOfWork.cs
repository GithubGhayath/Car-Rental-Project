using CarRental.Application.Repositories;
using CarRental.Application.Repositories.Common;
using CarRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _Context;
        public UnitOfWork(AppDbContext context)
        {
            _Context = context;
        }

        public ICustomerRepository CustomerRepository { get; }
        public IFuleTypeRepository FuleTypeRepository { get; }

        public IMaintenanceRepository MaintenanceRepository { get; }

        public IRentalBookingRepository RentalBookingRepository { get; }
        public IRentalTransactionRepository RentalTransactionRepository { get; }

        public IVehicleCategoryRepository VehicleCategoryRepository { get; }

        public IVehicleRepository VehicleRepository { get; }
        public IVehicleReturnRepository VehicleReturnRepository { get; }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
