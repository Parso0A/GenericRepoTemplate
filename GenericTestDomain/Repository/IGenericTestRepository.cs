using GenericTestDomain.Model;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericTestDomain.Repository
{
    public interface IGenericTestRepository<T> where T : EntityType
    {
        Task<bool> Add(T entity);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<bool> Any(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<List<T>> SearchBy(Expression<Func<T, bool>> searchBy, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<T> FindBy(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<bool> Update(T entity);
        Task<bool> Delete(Expression<Func<T, bool>> identity, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<bool> Delete(T entity);
        Task<bool> SaveAsync();
    }
}
