using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Models
{
    public class EmployeeCreateModel
    {
        public string EmployeeName { get; set; }

        public int DepartmentID { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public DateTime JoiningDate { get; set; }
        // Audit fields
       // public int CreatedBy { get; set; }

       // public DateTime CreatedDate { get; set; }

      //  public bool IsActive { get; set; }
    }
}
