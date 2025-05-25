using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hermes_SmartAttendanceSystem.Models
{
    public class RegisterViewModel
    {
        // Drop-down selections
        [Required]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        [Required]
        [Display(Name = "Position")]
        public int PositionID { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string UserRole { get; set; } // "Manager" or "Employee"

        public List<SelectListItem> Departments { get; set; } = new();
        public List<SelectListItem> Positions { get; set; } = new();
        public List<SelectListItem> Roles { get; set; } = new();

        [Display(Name = "Employee Code")]
        public string EmployeeCode { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        [Phone]
        public string EmployeeCN { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmployeeEmail { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Join Date")]
        public DateTime JoinDate { get; set; } = DateTime.Now;

        // User login info
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string UserPass { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("UserPass", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string UserFN { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string UserLN { get; set; }
    }
}
