using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class FuleTypeRepository:Repository<FuleType>, IFuleTypeRepository
    {
        private readonly AppDbContext _Context;
        public FuleTypeRepository(AppDbContext context) : base(context)
        {
            _Context = context;
        }

        public void Update(FuleType entity)
        {
            throw new NotImplementedException();
        }
    }
}
