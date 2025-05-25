using System.ComponentModel.DataAnnotations;
namespace Hermes_SmartAttendanceSystem.Models
{
    public class EmployeeViolation
    {
       
        [Key] 
        public int ViolationID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ViolationDate { get; set; }
        public string ViolationDetails { get; set; }
        public string GeneratedBy { get; set; }
        public DateTime GeneratedDate { get; set; }
    }

}
