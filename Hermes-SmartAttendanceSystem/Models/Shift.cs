namespace Hermes_SmartAttendanceSystem.Models
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
    }

}
