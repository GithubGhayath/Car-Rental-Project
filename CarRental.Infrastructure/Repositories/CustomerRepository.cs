using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        private readonly AppDbContext _Context;
        public CustomerRepository(AppDbContext context) : base(context)
        {
            _Context = context;
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
