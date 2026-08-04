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


    }
}
