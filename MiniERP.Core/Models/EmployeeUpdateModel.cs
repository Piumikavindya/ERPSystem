using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Models
{
    public class EmployeeUpdateModel
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; } = string.Empty;

        public int DepartmentID { get; set; }

        public string? Email { get; set; }

        public decimal? Salary { get; set; }

        public DateTime JoiningDate { get; set; }
    }
}
