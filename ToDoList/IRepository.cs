using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Create(T t);

        int Update(T t);

        void Delete(T t);

        IQueryable<T> All();

        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        T Find(params object[] keys);

        T Find(Expression<Func<T, bool>> predicate);
    }
}
