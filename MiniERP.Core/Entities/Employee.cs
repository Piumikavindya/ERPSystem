using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

     //   public string EmployeeCode { get; set; } = string.Empty;

        public string EmployeeName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public int DepartmentID { get; set; }
        public DateTime JoiningDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

    }
}
