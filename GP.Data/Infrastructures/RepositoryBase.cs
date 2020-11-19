﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructures
{
   public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private GPContext dataContext;
        readonly IDbSet<T> dbset;
        //instancie contexte o ydisposih
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            this.dataContext = dbFactory.MyContext;
            dbset = dataContext.Set<T>();
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();

        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null)
        {
            IQueryable<T> mydbset = dbset;
            if (condition != null)
                mydbset = mydbset.Where(condition);
            return mydbset.AsEnumerable();
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }
}
