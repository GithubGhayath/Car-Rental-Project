using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class RentalTransactionRepository : Repository<RentalTransaction>, IRentalTransactionRepository
    {
        private readonly AppDbContext _Context;

        public RentalTransactionRepository(AppDbContext context) : base(context)
        {
            _Context = context;
        }

        public void Update(RentalTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
