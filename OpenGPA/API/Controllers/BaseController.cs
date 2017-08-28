using DAL;
using System;
using System.Web.Http;
using OpenGPA.Helpers;

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
            _dataContext = ContextHelper.SetupContext();
        }

        public void Dispose()
        {

        }
    }
}