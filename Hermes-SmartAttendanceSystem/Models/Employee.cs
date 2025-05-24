namespace Hermes_SmartAttendanceSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeCN { get; set; }
        public string EmployeeEmail { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
    }

}
