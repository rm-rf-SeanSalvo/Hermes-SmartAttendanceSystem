using System.ComponentModel.DataAnnotations;

namespace Hermes_SmartAttendanceSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
