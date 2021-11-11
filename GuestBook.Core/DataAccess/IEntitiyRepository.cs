using GuestBook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Core.DataAccess
{
    public interface IEntitiyRepository<T> where T : class, IEntity,new()
    {
        public List<T> GetAll(Expression <Func<T,bool>> expression=null);
        public T Get(Expression <Func<T,bool>>expression);
        public T GetById(int id);
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        
    }
}
