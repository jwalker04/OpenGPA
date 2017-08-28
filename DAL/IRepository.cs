using DAL.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }
    }

    public interface IDataContext
    {
        IRepository<T> GetRepository<T>() where T : class;
        void AddRepository<T>() where T : class;
    }

    public class DataContext : IDataContext
    {

        private IDictionary<Type,object> _repositories;
        private DbContext _context;

        public DataContext()
        {
            _context = new Test_GPA();            
            _repositories = new Dictionary<Type,object>();
        }
        
        // Must create a new repository based on the incoming Type (i.e. ICourse, IAssignment)
        public void AddRepository<T>() where T : class
        {
            var repo = new Repository<T>(_context);

            _repositories.Add(typeof(T), repo);
        }


        // Must find repository based on incoming Type
        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
                return (IRepository<T>)_repositories[typeof(T)];

            return null;
        }        
    }
}
