using CarRental.Application.Repositories.Common;
using CarRental.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarRental.Infrastructure.Repositories.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _Context;
        private readonly DbSet<T> _Set;
        public Repository(AppDbContext context)
        {
            _Context = context;
            _Set = _Context.Set<T>();
        }

        public virtual void Add(T item)
        {
            _Set.Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            _Set.AddRange(items);
        }

        public T? Get(Expression<Func<T, bool>> Filter, Func<IQueryable<T>, IQueryable<T>>? Include=null)
        {
            IQueryable<T> query = _Set;

            query = query.Where(Filter);

            if (Include != null)
                query = Include(query);

            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? Filter=null, Func<IQueryable<T>, IQueryable<T>>? Include = null)
        {
            IQueryable<T> query = _Set;

            if (Filter is not null)
                query = query.Where(Filter);


            if (Include is not null)
                query = Include(query);

            return query.ToList();
        }

        public bool IsExists(Expression<Func<T, bool>> expression)
        {
            return _Set.Any(expression);
        }

        public virtual void Remove(T item)
        {
            _Set.Remove(item);
        }
    }
}
