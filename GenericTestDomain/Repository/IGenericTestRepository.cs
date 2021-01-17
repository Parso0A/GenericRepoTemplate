using GenericTestDomain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericTestDomain.Repository
{
    public interface IGenericTestRepository<T> where T : EntityType
    {
        Task<bool> Add(T entity);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<bool> Any(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<List<T>> SearchBy(Expression<Func<T, bool>> searchBy, params Expression<Func<T, object>>[] includes);
        Task<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<bool> Update(T entity);
        Task<bool> Delete(Expression<Func<T, bool>> identity, params Expression<Func<T, object>>[] includes);
        Task<bool> Delete(T entity);
        Task<bool> SaveAsync();
    }
}
