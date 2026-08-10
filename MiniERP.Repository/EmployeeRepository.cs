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

        public async Task<int> CreateEmployee(Employee entity)
        {

            using var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();

            parameters.Add("@EmployeeName", entity.EmployeeName);

            parameters.Add("@DepartmentID", entity.DepartmentID);

            parameters.Add("@Email", entity.Email);

            parameters.Add("@Salary", entity.Salary);

            parameters.Add("@JoiningDate", entity.JoiningDate);

            parameters.Add("@CreatedDate", entity.CreatedDate);


            var employeeId = await connection.ExecuteScalarAsync<int>("CreateEmployee", parameters, commandType: CommandType.StoredProcedure);

            return employeeId;

        }

        public async Task<EmployeeDto?> GetEmployeeById(int employeeId)
        {
            using var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", employeeId);

            var employee = await connection.QueryFirstOrDefaultAsync<EmployeeDto>("GetEmployeeById", parameters, commandType: CommandType.StoredProcedure);

            return employee;
        }

        public async Task<int> UpdateEmployee(Employee entity)
        {
            using var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();

            parameters.Add("GetEmployeeById", entity.EmployeeId);
            parameters.Add("@EmployeeName", entity.EmployeeName);

            parameters.Add("@DepartmentID", entity.DepartmentID);

            parameters.Add("@Email", entity.Email);

            parameters.Add("@Salary", entity.Salary);

            parameters.Add("@JoiningDate", entity.JoiningDate);


            var rowsAffected = await connection.ExecuteScalarAsync<int>("UpdateEmployee", parameters, commandType: CommandType.StoredProcedure);
    
            return rowsAffected;
        }


        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            using var connection = _dapperContext.CreateConnection();

            var employees = await connection.QueryAsync<EmployeeDto>("GetEmployees", commandType: CommandType.StoredProcedure);

            return employees;
        }


        public async Task<int> DeleteEmployee(int employeeId)
        {
            var connection = _dapperContext.CreateConnection();

            var parameters = new DynamicParameters();

            parameters.Add("EmployeeID", employeeId);

            var emp = await connection.ExecuteScalarAsync<int>("DeleteEmployees", parameters, commandType: CommandType.StoredProcedure);

            return emp;
        }

    }  
}
