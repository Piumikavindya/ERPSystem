using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Entities;
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

        public async Task<int> CreateEmployee(EmployeeCreateModel model)
        {
            var employee = new Employee
            {
                EmployeeName = model.EmployeeName,
                DepartmentID = model.DepartmentID,
                Email = model.Email,
                Salary = model.Salary,
                JoiningDate = model.JoiningDate,

                IsActive = true,
                CreatedDate = DateTime.Now
            };

            return await _employeeRepository.CreateEmployee(employee);
        }

       public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        Task IEmployeeService.DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<List<EmployeeDto>> IEmployeeService.GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        Task IEmployeeService.UpdateEmployee(EmployeeUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
