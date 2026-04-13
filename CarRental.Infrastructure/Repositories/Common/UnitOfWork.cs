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
        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
