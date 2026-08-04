using Dapper;
using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Entities;
using MiniERP.Core.Interfaces.Repositories;
using MiniERP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _dapperContext;
        public EmployeeRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<int> CreateEmployee(Employee entity) { 
        
        using var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();

            parameters.Add("@EmployeeName", entity.EmployeeName);

            parameters.Add("@DepartmentID", entity.DepartmentID);

            parameters.Add("@Email", entity.Email);

            parameters.Add("@Salary", entity.Salary);

            parameters.Add("@JoiningDate", entity.JoiningDate);

            var employeeId = await connection.ExecuteScalarAsync<int>("CreateEmployee", parameters, commandType: CommandType.StoredProcedure);

            return employeeId;


        }

        public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            using var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", employeeId);

            var employee = await connection.QueryFirstOrDefaultAsync<EmployeeDto>( "GetEmployeeById", parameters, commandType: CommandType.StoredProcedure);

            return employee;
        }

        Task IEmployeeRepository.DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<List<Employee>> IEmployeeRepository.GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        Task IEmployeeRepository.UpdateEmployee(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
