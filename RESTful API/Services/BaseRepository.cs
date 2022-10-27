using Microsoft.EntityFrameworkCore;
using RESTful_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Services
{
    public abstract class BaseRepository<T> where T : class
    {
        protected DataBaseContext DataContext;
        protected readonly DbSet<T> DbSet;

        protected BaseRepository(DataBaseContext dataContext)
        {
            DataContext = dataContext;
            DbSet = dataContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            DbSet.Add(entity);
            DataContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            DataContext.Entry(entity).State = EntityState.Modified;
            DataContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
            DataContext.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }
    }
}
