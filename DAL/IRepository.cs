using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(Guid id);
    }

    public interface IDataContext
    {
        IRepository<T> GetRepository<T>() where T : class;
        void AddRepository();
    }

    public class DataContext : IDataContext
    {

        private IDictionary<Type,object> _repositories;
        //private DataContext _dataContext;

        public DataContext()
        {
            //_dataContext = new Test_GPA();
            _repositories = new Dictionary<Type,object>();
        }
        
        // Must create a new repository based on the incoming Type (i.e. ICourse, IAssignment)
        public void AddRepository()
        {
            //_repositories.Add();
        }


        // Must find repository based on incoming Type
        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
                return (IRepository<T>)_repositories[typeof(T)];

            return null;
        }
        
    }



    public static class ContextHelper
    {
        public static IDataContext NewContext()
        {
            return new DataContext();
        }
    }
}
