﻿using BTRServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BTRServices.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected BTRDbContext _context; //used in derived classes

        public Repository(BTRDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity,bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        TEntity IRepository<TEntity>.Get(int key)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}