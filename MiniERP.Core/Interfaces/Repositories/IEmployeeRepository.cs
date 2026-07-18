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

        Task UpdateEmployee(Employee entity);

        Task DeleteEmployee(int employeeId);

        Task<Employee?> GetEmployeeById(int employeeId);

        Task<List<Employee>> GetAllEmployees();
    }
}
