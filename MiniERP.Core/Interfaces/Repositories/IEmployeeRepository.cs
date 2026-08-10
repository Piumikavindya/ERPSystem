using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<int> CreateEmployee(Employee entity);

        Task<int> UpdateEmployee(Employee entity);

        Task<int> DeleteEmployee(int employeeId);

        Task<EmployeeDto?> GetEmployeeById(int employeeId);

        Task<IEnumerable<EmployeeDto>> GetEmployees();
    }
}
