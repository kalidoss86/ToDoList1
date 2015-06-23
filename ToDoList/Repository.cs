using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DBConnection;

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
            return DbSet.Where(predicate).AsQueryable<TObject>();
        }

        public TObject Find(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public TObject Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public int Update(TObject t)
        {
            var entry = Context.Entry(t);
            DbSet.Attach(t);
            entry.State = EntityState.Modified;
            Context.SaveChanges();
            return 0;
        }
    }
}
