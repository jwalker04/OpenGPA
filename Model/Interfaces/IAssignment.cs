using System;

namespace Model.Interfaces
{
    public interface IAssignment
    {
        Guid AssignmentID { get; set; }
        string Name { get; set; }
        double Grade { get; set; }
        DateTime DueDate { get; set; }
        IAssignmentType AssignmentType { get; set; }
    }
}