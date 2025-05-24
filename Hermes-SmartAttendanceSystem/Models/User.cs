namespace Hermes_SmartAttendanceSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string UserPass { get; set; }
        public string UserFN { get; set; }
        public string UserLN { get; set; }
        public string UserRole { get; set; } // "Manager" or "Employee"
    }

}
