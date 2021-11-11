using GuestBook.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using var context = new TContext();
            var entry = context.Entry(entity);
            entry.State = EntityState.Added;
            context.SaveChanges();
            return entity;

        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var entry = context.Entry(entity);
            entry.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using var context = new TContext();
            var result = context.Set<TEntity>().FirstOrDefault(expression);
            if (result != null)
                return result;
            return null;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using var context = new TContext();
            var result = expression == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(expression).ToList();
            if (result.Count > 0)
                return result;
            return null;
        }

        public TEntity GetById(int id)
        {
            using var context = new TContext();
            var result = context.Set<TEntity>().Find(id);
            if (result != null)
                return result;
            else
                return null;

        }

        public TEntity Update(TEntity entity)
        {
            using var context = new TContext();
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }
    }
}
