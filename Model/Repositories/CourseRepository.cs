using DAL;
using Model.Classes;
using System;

namespace Model.Repositories
{
    public class CourseRepository : IRepository<Course>
    {


        public CourseRepository()
        {

        }

        public void Add(Course t)
        {

        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}