using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<int> CreateEmployee(EmployeeCreateModel model);

        Task UpdateEmployee(EmployeeUpdateModel model);

        Task DeleteEmployee(int employeeId);

        Task<EmployeeDetailsDto?> GetEmployeeById(int employeeId);

        Task<List<EmployeeDto>> GetAllEmployees();

    }
}
