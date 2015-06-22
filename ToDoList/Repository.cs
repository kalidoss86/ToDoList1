using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Repository<TObject> : IRepository<TObject>
        where TObject : class
    {
        protected TodoListDbEntities Context = null;

        public Repository()
        {
            Context = new TodoListDbEntities();
        }

        public Repository(TodoListDbEntities context)
        {
            this.Context = context;
        }

        protected DbSet<TObject> DbSet
        {
            get
            {
                return Context.Set<TObject>();
            }
        }

        public IQueryable<TObject> All()
        {
            return DbSet.AsQueryable();
        }

        public TObject Create(TObject t)
        {
            var newEntry = DbSet.Add(t);
            Context.SaveChanges();
            return newEntry;
        }

        public void Delete(TObject t)
        {
            DbSet.Remove(t);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }

        public IQueryable<TObject> Filter(Expression<Func<TObject, bool>> predicate)
        {
            //TODO Need to implement this function
            throw new NotImplementedException();
        }

        public TObject Find(Expression<Func<TObject, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TObject Find(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public int Update(TObject t)
        {
            throw new NotImplementedException();
        }
    }
}
