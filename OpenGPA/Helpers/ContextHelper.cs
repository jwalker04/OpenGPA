using DAL;
using Model.Interfaces;

namespace OpenGPA.Helpers
{
    public static class ContextHelper
    {
        public static IDataContext SetupContext()
        {
            // Register this -> This one is only meant to be used to perform Gets
            var dataContext = NewContext();
            dataContext.AddRepository<IAssignment>();
            dataContext.AddRepository<IAssignmentType>();

            dataContext.AddRepository<ICourse>();

            return dataContext;
        }

        private static IDataContext NewContext()
        {
            return new DataContext();
        }
    }
}