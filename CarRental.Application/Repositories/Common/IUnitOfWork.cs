using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Repositories.Common
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IFuleTypeRepository FuleTypeRepository { get; }
        IMaintenanceRepository MaintenanceRepository { get; }
        IRentalBookingRepository RentalBookingRepository { get; }   
        IRentalTransactionRepository RentalTransactionRepository { get; }
        IVehicleCategoryRepository VehicleCategoryRepository { get; }
        IVehicleRepository VehicleRepository { get; }
        IVehicleReturnRepository VehicleReturnRepository { get; }
        void Save();
    }
}
