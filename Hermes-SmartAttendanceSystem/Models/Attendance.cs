namespace Hermes_SmartAttendanceSystem.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double HoursWorked { get; set; }
    }

}
