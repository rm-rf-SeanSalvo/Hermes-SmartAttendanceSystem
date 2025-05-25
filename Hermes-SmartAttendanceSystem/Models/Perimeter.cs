using System.ComponentModel.DataAnnotations;
namespace Hermes_SmartAttendanceSystem.Models
{
    public class Perimeter
    {
        [Key]
        public int PerimeterID { get; set; }
        public string PerimeterName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Radius { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
