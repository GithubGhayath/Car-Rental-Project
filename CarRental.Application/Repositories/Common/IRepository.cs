using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarRental.Application.Repositories.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? Filter, Func<IQueryable<T>, IQueryable<T>>? Include);
        T? Get(Expression<Func<T, bool>> Filter, Func<IQueryable<T>, IQueryable<T>>? Include);
        void Add(T item);
        void Remove(T item);
        void AddRange(IEnumerable<T> items);
        bool IsExists(Expression<Func<T, bool>> expression);
    }
}
