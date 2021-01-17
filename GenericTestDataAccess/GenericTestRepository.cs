﻿using GenericTestDomain.Model;
using GenericTestDomain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericTestDataAccess
{
    public class GenericTestRepository<T> : IGenericTestRepository<T> where T : EntityType
    {
        private GenericTestContext _context;
        public GenericTestRepository(GenericTestContext context)
        {
            _context = context;
        }
        public virtual async Task<bool> Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
        public Task<bool> Any(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> results = _context.Set<T>().Where(predicate);
            foreach (Expression<Func<T, object>> includeExpression in includes)
                results = results.Include(includeExpression);
            if (results.Any())
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
        public virtual async Task<bool> Delete(Expression<Func<T, bool>> identity, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> results = _context.Set<T>().Where(identity);
            foreach (Expression<Func<T, object>> includeExpression in includes)
                results = results.Include(includeExpression);
            try
            {
                _context.Set<T>().RemoveRange(results);
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
        public virtual async Task<bool> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await Task.FromResult(true);
        }
        public virtual async Task<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result = _context.Set<T>().Where(predicate);
            foreach (Expression<Func<T, object>> includeExpression in includes)
                result = result.Include(includeExpression);
            return await result.FirstOrDefaultAsync();
        }
        public virtual async Task<List<T>> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public virtual async Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result = _context.Set<T>().Where(predicate);
            foreach (Expression<Func<T, object>> includeExpression in includes)
                result = result.Include(includeExpression);
            return await result.ToListAsync();
        }
        public Task<bool> SaveAsync()
        {
            try
            {
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
        public virtual async Task<List<T>> SearchBy(Expression<Func<T, bool>> searchBy, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result = _context.Set<T>().Where(searchBy);
            foreach (Expression<Func<T, object>> includeExpression in includes)
                result = result.Include(includeExpression);
            return await result.ToListAsync();
        }
        public virtual async Task<bool> Update(T entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _context.Set<T>().Attach(entity);
                }
                _context.Entry(entity).State = EntityState.Modified;
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
    }
}
