using TimesheetManagement_API.Models;

namespace TimesheetManagement_API.DTOs
{
    public class EmployeeDataResponse
    {
        public List<Employee> EmployeeList { get; set; }

        public EmployeeDataResponse()
        { 
            EmployeeList = new List<Employee>();
        }
    }
}
