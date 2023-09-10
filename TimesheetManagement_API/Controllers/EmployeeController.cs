using Microsoft.AspNetCore.Mvc;
using TimesheetManagement_API.DTOs;
using TimesheetManagement_API.Services;

namespace TimesheetManagement_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet(Name = "GetEmployeeData")]
        public EmployeeDataResponse Get()
        {
            EmployeeService employeeService = new EmployeeService();
            var respose = employeeService.GetEmployeeData();

            return respose;
        }
    }
}