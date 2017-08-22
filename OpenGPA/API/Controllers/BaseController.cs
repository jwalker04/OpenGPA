using DAL;
using System;
using System.Web.Http;

namespace OpenGPA.API.Controllers
{
    public class BaseController : ApiController
    {
    }

    public class UnitOfWork : IDisposable
    {
        IDataContext _dataContext;

        public UnitOfWork()
        {
            _dataContext = ContextHelper.NewContext();
        }

        public void Dispose()
        {

        }
    }
}