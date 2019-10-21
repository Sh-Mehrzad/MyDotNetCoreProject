﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repo
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetAllAsQueryable();
        T Get(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryList();
        Task<int> GetCountAsync();
        Task<T> GetAsync(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
        void DeleteRange(T[] entitys);        
        
    }
}
