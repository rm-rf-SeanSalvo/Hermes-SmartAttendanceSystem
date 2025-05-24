namespace Hermes_SmartAttendanceSystem.Models
{
    public class PerimeterAssignment
    {
        public int AssignmentID { get; set; }
        public int EmployeeID { get; set; }
        public int PerimeterID { get; set; }
        public DateTime WorkingDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}
