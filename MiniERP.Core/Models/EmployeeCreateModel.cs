using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Models
{
    public class EmployeeCreateModel
    {
        [Required]
        [StringLength(200)]
        public string EmployeeName { get; set; }

        [Range(1, int.MaxValue)]
        public int DepartmentID { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(0, 999999999)]
        public decimal Salary { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }
        // Audit fields
       // public int CreatedBy { get; set; }

       // public DateTime CreatedDate { get; set; }

      //  public bool IsActive { get; set; }
    }
}
