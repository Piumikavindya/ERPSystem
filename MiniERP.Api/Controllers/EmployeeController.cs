using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return Ok(employeeID);
        }
    }
}
