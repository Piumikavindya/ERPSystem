using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Interfaces.Repositories;
using MiniERP.Core.Interfaces.Services;
using MiniERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        Task<int> IEmployeeService.CreateEmployee(EmployeeCreateModel model)
        {
            throw new NotImplementedException();
        }

        Task IEmployeeService.DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<List<EmployeeDto>> IEmployeeService.GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        Task<EmployeeDetailsDto?> IEmployeeService.GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task IEmployeeService.UpdateEmployee(EmployeeUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
