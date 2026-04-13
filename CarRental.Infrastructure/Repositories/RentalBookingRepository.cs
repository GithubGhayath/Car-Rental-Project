using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Repositories
{
    public class RentalBookingRepository:Repository<RentalBooking>,IRentalBookingRepository 
    {
        private readonly AppDbContext _Context;
        public RentalBookingRepository(AppDbContext context) : base(context) 
        {
            _Context = context;
        }

        public void Update(RentalBooking newBooking)
        {
            throw new NotImplementedException();
        }
    }
}
