using FA.BookStore.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly BookStoreContext context;
        protected DbSet<TEntity> dbSet;
        public GenericRepository(BookStoreContext context = null)
        {
            this.context = context ?? new BookStoreContext();
            dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {

            //context.Entry<TEntity>(entity).State = EntityState.Added;
            dbSet.Add(entity);
            context.SaveChanges();
        }


        public void CreateRange(TEntity entity)
        {
            dbSet.AddRange(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            if (entityToDelete != null)
            {
                dbSet.Remove(entityToDelete);
                context.SaveChanges();
            }
        }

        public TEntity Find(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public void Update(TEntity entity)
        {

            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void UpdateRange(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
