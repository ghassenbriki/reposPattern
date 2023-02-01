﻿using reposPattern.Database;
using reposPattern.Interfaces;
using System.Linq.Expressions;
using System.Xml.Linq;
using System;

namespace reposPattern.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
            
        }
        
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)

        {
            _context.Set<T>().RemoveRange(entities);
        }
        public IEnumerable<T> Find(Func<T, bool> expression) // T input ; bool output 
        {
            return _context.Set<T>().Where(expression);
        }

    }
}
