using getpostapi.Models;
using getpostapi.Services;

using Microsoft.AspNetCore.Mvc;

namespace getpostapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeServices employeeServices;

        public EmployeesController(IEmployeeServices employeeServices)
        {
            this.employeeServices = employeeServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {

            return Ok(await employeeServices.GetAllEmployees());
        }

        [HttpPost()]
        public async Task<IActionResult> AddNewEmployees([FromBody] Employee employee)
        {
            return Ok(await employeeServices.AddNewEmployee(employee));
        }
    }
}
