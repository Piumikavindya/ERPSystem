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
                // can add additional feilds here. Now the client cannot manipulate those values.
                //IsActive = true,
                CreatedDate = DateTime.Now
            };

            return await _employeeRepository.CreateEmployee(employee);
        }

       public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        public async Task<int> UpdateEmployee(EmployeeUpdateModel model)
        {
            var employeeEntity = new Employee
            {
                EmployeeId = model.EmployeeID,
                EmployeeName = model.EmployeeName,
                DepartmentID = model.DepartmentID,
                Email = model.Email,
                Salary = model.Salary,
                JoiningDate = model.JoiningDate,
            };

            var employee = await _employeeRepository.UpdateEmployee(employeeEntity);

            return employee;

            
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }
        public async Task<int> DeleteEmployee(int employeeId)
        {
            return await _employeeRepository.DeleteEmployee(employeeId);

        }




    }
}
