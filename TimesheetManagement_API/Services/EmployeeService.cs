using TimesheetManagement_API.DTOs;
using TimesheetManagement_API.Interfaces;

namespace TimesheetManagement_API.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDataResponse GetEmployeeData()
        {
            EmployeeDataResponse response = new EmployeeDataResponse();

            response.EmployeeList.Add(new Models.Employee()
            {
                Name = "Bhairav Pardiwala",
                Designation = "Sr. Software Developer",
                IsBillable = false,
                OtherSkills = "Angular, React etc",
                Comments = new string[] { "Comment_1" }
            });

            response.EmployeeList.Add(new Models.Employee()
            {
                Name = "Technical Lead 1",
                Designation = "Sr. Software Developer",
                IsBillable = true,
                OtherSkills = "Angular",
                Comments = new string[] { "Comment_1" }
            });

            response.EmployeeList.Add(new Models.Employee()
            {
                Name = "Developer 1",
                Designation = "Sr. Software Developer",
                IsBillable = true,
                OtherSkills = "Angular",
                Comments = new string[] { "Comment_1" }
            });

            response.EmployeeList.Add(new Models.Employee()
            {
                Name = "Developer 2",
                Designation = "Sr. Software Developer",
                IsBillable = true,
                OtherSkills = "Angular",
                Comments = new string[] { "Comment_1" }
            });

            return response;
        }
    }
}
