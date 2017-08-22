using Model.Interfaces;
using System;

namespace Model.Interfaces
{
    public interface IAssignmentType
    {
        Guid AssignmentTypeID { get; set; }
        string Name { get; set; }
        double Weight { get; set; }
        double OverallGrade { get; set; }
        ICourse Course { get; set; }
    }
}