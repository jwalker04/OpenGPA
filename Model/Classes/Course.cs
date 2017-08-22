using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Course : ICourse
    {
        public Guid CourseID { get; set; }
        public string Name { get; set; }
    }
}
