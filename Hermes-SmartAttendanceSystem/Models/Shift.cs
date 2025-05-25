using System.ComponentModel.DataAnnotations;
namespace Hermes_SmartAttendanceSystem.Models
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
    }

}
