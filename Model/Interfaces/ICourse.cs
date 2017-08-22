using System;

namespace Model.Interfaces
{
    public interface ICourse
    {
        Guid CourseID { get; set; }
        string Name { get; set; }
        //double CreditHours { get; set; }
        //double OverallGrade { get; set; }
    }
}