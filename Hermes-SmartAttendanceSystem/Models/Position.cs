using System.ComponentModel.DataAnnotations;
namespace Hermes_SmartAttendanceSystem.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
    }
}
