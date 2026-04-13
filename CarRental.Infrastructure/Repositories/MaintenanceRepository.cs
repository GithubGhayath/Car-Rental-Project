using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class MaintenanceRepository:Repository<Maintenance>, IMaintenanceRepository
    {
        private readonly AppDbContext _Context;
        public MaintenanceRepository(AppDbContext context) : base(context)
        {
            _Context = context;
        }

        public void Update(Maintenance entity)
        {
            throw new NotImplementedException();
        }
    }
}
