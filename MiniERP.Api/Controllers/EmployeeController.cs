using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Core.DTOs.Employee;
using MiniERP.Core.Interfaces.Services;
using MiniERP.Core.Models;

namespace MiniERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateModel model)
        {
            var employeeID = await _employeeService.CreateEmployee(model);
            return CreatedAtAction(
        nameof(GetEmployeeById),
        new { id = employeeID },
        new
        {
            EmployeeId = employeeID,
            Message = "Employee created successfully."
        });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployees()
        {
            var employees = await _employeeService.GetEmployees();

            return Ok(employees);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeUpdateModel model)
        {
            if (id != model.EmployeeID)
            {
                return BadRequest("Route ID and Employee ID do not match.");
            }

            var rowsAffected = await _employeeService.UpdateEmployee(model);

            if (rowsAffected == 0)
            {
                return NotFound("Employee not found.");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var rowsAffected = await _employeeService.DeleteEmployee(id);

            if (rowsAffected == 0)
            {
                return NotFound($"Employee with ID {id} was not found.");
            }

            return NoContent();
        }
    }
}
