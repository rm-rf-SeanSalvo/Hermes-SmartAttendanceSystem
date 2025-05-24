namespace Hermes_SmartAttendanceSystem.Models
{
    public class RequestApplication
    {
        public int RequestApplicationID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NoOfDays { get; set; }
        public int? NoOfHours { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string LeaveType { get; set; }
    }
}
