using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Repositories.Common
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
